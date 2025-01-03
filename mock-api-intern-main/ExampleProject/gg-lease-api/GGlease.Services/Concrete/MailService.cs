using SendGrid.Helpers.Mail;
using SendGrid;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using GGlease.Services.Interfaces;
using GGlease.Model.ViewModel;

namespace GGlease.Services.Concrete
{
    public class MailService : IMailService
    {
        private readonly string apiKey;
        private readonly string fromAddress;
        private readonly string fromName;
        private readonly ILogger<MailService> logger;

        public MailService(IConfiguration configuration, ILogger<MailService> logger)
        {
            apiKey = configuration["SendGrid:ApiKey"];
            fromName = configuration["SendGrid:FromName"];
            fromAddress = configuration["SendGrid:FromEmail"];
            this.logger = logger;
        }

        public async Task<ValidatedModel<bool>> SendEmailAsync(EmailMessage message)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new SendGrid.Helpers.Mail.EmailAddress(fromAddress, fromName),
                Subject = message.Subject,
                HtmlContent = message.Body
            };

            foreach (var item in message.To)
                msg.AddTo(new SendGrid.Helpers.Mail.EmailAddress(item.Address, item.Name));

            var response = await client.SendEmailAsync(msg);

            if (response == null)
            {
                logger.LogError("mail response is null");

                return new ValidatedModel<bool>("Mail gönderimi başarısız");
            }
            else
            {
                if (response.IsSuccessStatusCode == true)
                    return new ValidatedModel<bool>(true);

                var responseMessage = await response.Body.ReadAsStringAsync();

                return new ValidatedModel<bool>($"Mail gönderimi başarısız. Status: {response.StatusCode} - {responseMessage}");
            }

        }
    }
}
