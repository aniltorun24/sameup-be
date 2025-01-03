using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IAuthService
    {
        UserDetailModel? CurrentUser { get; }
        ValidatedModel<UserDetailModel> WriteToken(UserDetailModel user);
        void RemoveToken();
    }
}
