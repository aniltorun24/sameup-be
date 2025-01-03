using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IMailService
    {
        Task<ValidatedModel<bool>> SendEmailAsync(EmailMessage message);
    }
}
