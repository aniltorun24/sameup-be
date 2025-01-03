using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IOfferService
    {
        Task<ValidatedModel<IEnumerable<OfferGuestViewModel>>> RetrieveOffersForGuestAsync(OfferCalculatorRequestModel requestModel);
    }
}