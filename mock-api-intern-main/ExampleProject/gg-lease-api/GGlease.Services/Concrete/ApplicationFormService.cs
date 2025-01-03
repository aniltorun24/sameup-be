using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GGlease.Services.Concrete
{
    public class ApplicationFormService : IApplicationFormService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly IOfferService _offerService;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public ApplicationFormService(DataContext dataContext, IConfiguration configuration, IMapper mapper, IOfferService offerService, IMailService mailService)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            _offerService = offerService;
            _mailService = mailService;
            _configuration = configuration;
        }

        public async Task<ValidatedModel<int>> CreateAsync(ApplicationFormCreateModel applicationFormCreateModel)
        {
            bool withOffer = applicationFormCreateModel.Offers != null &&
                applicationFormCreateModel.CalculationParameters != null;

            //string adminMailMessage = "";
            string customerMailMessage = @$"Merhabalar,
                <br><br>
                GGlease'i tercih ettiğiniz için teşekkürler. 
                <br>
                Leasing talebiniz bize ulaştı. En kısa zamanda sizinle iletişime geçeceğiz.";

            //var adminToAddresses = _configuration["SendGrid:AdminEmails"].Split(',').Select(address => new EmailAddress(address.Trim(), "GGLease"));
            int applicationFormId = 0;
            if (withOffer)
            {
                customerMailMessage += "<br><br>Teklifinizin detaylarını aşağıda görebilirsiniz;<br>";
                var validatedModel = await _offerService.RetrieveOffersForGuestAsync(applicationFormCreateModel.CalculationParameters);
                var sortedOffers = validatedModel.Data.Select(x => x.FinancialCompany.Id);
                var dataSecure = sortedOffers.SequenceEqual(applicationFormCreateModel.Offers.Select(x => x.FinancialCompanyId));
                if (!dataSecure) return new ValidatedModel<int>("Hatalı Başvuru");
                var applicationForm = _mapper.Map<ApplicationForm>(applicationFormCreateModel);
                await _dataContext.ApplicationForms.AddAsync(applicationForm);
                await _dataContext.SaveChangesAsync();

                List<Offer> offers = new List<Offer>();
                foreach (var item in applicationFormCreateModel.Offers)
                {
                    OfferGuestViewModel model = validatedModel.Data.FirstOrDefault(x => x.FinancialCompany.Id == item.FinancialCompanyId);

                    var rate = _dataContext.Rates.Where(x => x.FinancialCompanyId == item.FinancialCompanyId
                        && x.CurrencyId == applicationFormCreateModel.CalculationParameters.CurrencyId
                        && x.MaturityOptionId == applicationFormCreateModel.CalculationParameters.MaturityOptionId
                        && x.IsActive).FirstOrDefault();
                    Offer newItem = new Offer()
                    {
                        ApplicationFormId = applicationForm.Id,
                        CurrencyId = applicationFormCreateModel.CalculationParameters.CurrencyId,
                        MaturityOptionId = applicationFormCreateModel.CalculationParameters.MaturityOptionId,
                        FinancialCompanyId = item.FinancialCompanyId,
                        IsAccepted = item.IsAccepted,
                        Payment = applicationFormCreateModel.CalculationParameters.AdvancePayment,
                        RateValue = rate.RateValue,
                        EquipmentValue = applicationFormCreateModel.CalculationParameters.EquipmentValue,
                        MonthlyPaymentValue = model.MonthlyPaymentValue,
                        TotalPaymentValue = model.TotalPaymentValue,
                    };

                    offers.Add(newItem);
                    if (item.IsAccepted)
                    {
                        var currencyName = _dataContext.Currencies.Where(x => x.Id == newItem.CurrencyId).FirstOrDefault().Name;
                        var financialCompanyName = string.IsNullOrWhiteSpace(model.FinancialCompany.Name) ? "Özel Teklif" : model.FinancialCompany.Name;
                        customerMailMessage += "Finansal Firma: " + financialCompanyName + "<br>";
                        customerMailMessage += "Toplam Ödeme: " + newItem.TotalPaymentValue + " " + currencyName + "<br>";
                        customerMailMessage += "Ekipman Tutarı: " + newItem.EquipmentValue + " " + currencyName + "<br>";
                        customerMailMessage += "Aylık Ödeme: " + newItem.MonthlyPaymentValue + " " + currencyName + "<br>";
                        customerMailMessage += "Vade: " + _dataContext.MaturityOptions.Where(x => x.Id == newItem.MaturityOptionId).FirstOrDefault().Name + "<br>";
                    }
                }

                await _dataContext.Offers.AddRangeAsync(offers);
                await _dataContext.SaveChangesAsync();

                applicationFormId = applicationForm.Id;
                //TODO: Mail implementasyonlarını buraya taşı
            }
            else
            {
                var applicationForm = _mapper.Map<ApplicationForm>(applicationFormCreateModel);

                await _dataContext.ApplicationForms.AddAsync(applicationForm);
                await _dataContext.SaveChangesAsync();

                applicationFormId = applicationForm.Id;
                //TODO: Mail implementasyonlarını buraya taşı
            }

            customerMailMessage += "<br><br>İyi günler dileriz";
            List<EmailAddress> toAddresses = new List<EmailAddress>();
            toAddresses.Add(new EmailAddress(applicationFormCreateModel.Email, "GGLease"));
            await _mailService.SendEmailAsync(new EmailMessage(toAddresses, "gglease.com’a Hoşgeldiniz", customerMailMessage));

            if (applicationFormId != 0)
            {

                var applicationFormMailInfo = await _dataContext
                    .ApplicationForms
                    .Where(x => x.Id == applicationFormId)
                    .ProjectTo<ApplicationFormAdminMailModel>(_mapper.ConfigurationProvider)
                    .FirstAsync();

                var styleText = @"
                    table td {
                        text-align:left;
                        background: #ffffff;
                        color: black;
                    }
                ";

                var adminMailMessage =
                    @$"
                    <!DOCTYPE html>
                        <html>
                        <head>
                            <title>HTML Table Generator</title> 
                            <style>
                                {styleText}
                            </style>
                        </head>
                        <body>
                            Sayın yetkili,<br>
                            Aşağıdaki bilgiler ışığında müşterimizin leasing talebinin değerlendirilmesi için adı geçen başvuru sahibi ile iletişime geçilmesini rica ederiz.<br>
                            Saygılarımızla,<br>
                            GG Finansal Danışmanlık ve Teknoloji A.Ş.<br>
                            <br>
                            <table>
                                <tbody>
                                    <tr> <td>Ana Kategori</td> <td>:</td> <td>{applicationFormMailInfo.MainCategory}</td></tr>
                                    <tr> <td>Alt Kategori</td> <td>:</td> <td>{applicationFormMailInfo.SubCategory}</td></tr>
                                    <tr> <td>Satıcı Firma</td> <td>:</td> <td>{applicationFormMailInfo.SellerCompany}</td></tr>
                                    <tr> <td>Ad - Soyad</td> <td>:</td> <td>{applicationFormMailInfo.NameSurname}</td></tr>
                                    <tr> <td>E-Posta</td> <td>:</td> <td>{applicationFormMailInfo.Email}</td></tr>
                                    <tr> <td>Telefon Numarası</td> <td>:</td> <td>{applicationFormMailInfo.Phone}</td></tr>
                                    <tr> <td>Firma İsmi</td> <td>:</td> <td>{applicationFormMailInfo.CompanyName}</td></tr>
                                    <tr> <td>Firma Vergi Kimlik Numarası</td> <td>:</td> <td>{applicationFormMailInfo.CompanyVKN}</td></tr>
                                    <tr> <td>Açıklama</td> <td>:</td> <td>{applicationFormMailInfo.Description}</td></tr>
                                    <tr> <td>Seçilen Finansal Kuruluş</td> <td>:</td> <td>{applicationFormMailInfo.OfferCompanyId}</td></tr>
                                    <tr> <td>Mal Bedeli</td> <td>:</td> <td>{applicationFormMailInfo.OfferCompanyEquipmentValueWithCurrency}</td></tr>
                                    <tr> <td>Aylık Ödeme</td> <td>:</td> <td>{applicationFormMailInfo.OfferCompanyMonthlyPaymentValueWithCurrency}</td></tr>
                                    <tr> <td>Vade</td> <td>:</td> <td>{applicationFormMailInfo.OfferCompanyMaturityOption}</td></tr>
                                    <tr> <td>Toplam Ödeme</td> <td>:</td> <td>{applicationFormMailInfo.OfferCompanyTotalPaymentValueWithCurrency}</td></tr>
                                </tbody>
                            </table>
                    </body>
                </html>
                ";

                List<EmailAddress> toAdminAddresses = new List<EmailAddress>();
                toAdminAddresses = _configuration["SendGrid:AdminEmails"].Split(',').Select(address => new EmailAddress(address.Trim(), "")).ToList();

                await _mailService.SendEmailAsync(new EmailMessage(toAdminAddresses, "GGlease.com - Yeni Talep Oluşturuldu", adminMailMessage));
            }

            return new ValidatedModel<int>(0);
        }

        public async Task<ValidatedModel<PagedDataModel<ApplicationFormViewModel>>> AllAsync(SearchModel model)
        {
            var itemCount = await _dataContext.ApplicationForms.CountAsync();
            var applicationForms = await _dataContext.ApplicationForms
                .Include(cmp => cmp.Offers)
                .ThenInclude(cmpo => cmpo.FinancialCompany)
                .Include(cmp => cmp.Offers)
                .ThenInclude(cmpo => cmpo.Currency)
                .Include(cmp => cmp.Offers)
                .ThenInclude(cmpo => cmpo.MaturityOption)
                .Include(cmp => cmp.EquipmentSellerCompany)
                .ThenInclude(tcmp => tcmp.SellerCompany)
                .Include(tcmp => tcmp.EquipmentSellerCompany)
                .ThenInclude(tcmp => tcmp.Equipment)
                .ThenInclude(x => x.EquipmentGroup)
                .OrderByDescending(x => x.CreatedOn)
                .Skip(model.RowIndex)
                .Take(model.PageSize)
                .ToListAsync();
            var result = _mapper.Map<IEnumerable<ApplicationFormViewModel>>(applicationForms);

            var obj = new PagedDataModel<ApplicationFormViewModel>
            {
                Data = result,
                PageNo = model.PageNo,
                PageSize = model.PageSize,
                ItemCount = itemCount
            };

            return new ValidatedModel<PagedDataModel<ApplicationFormViewModel>>(obj);
        }
    }
}