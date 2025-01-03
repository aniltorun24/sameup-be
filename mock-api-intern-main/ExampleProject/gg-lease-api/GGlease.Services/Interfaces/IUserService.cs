using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IUserService
    {
        Task<ValidatedModel<UserDetailModel>> LoginAsync(UserLoginModel model);
        Task<ValidatedModel<UserDetailModel>> CreateAsync(UserCreateModel model);
        Task<ValidatedModel<UserPasswordResetModel>> ActivateAsync(UserPasswordResetModel model);
        Task<ValidatedModel<UserPasswordResetRequestModel>> ResetPasswordRequestAsync(UserPasswordResetRequestModel model);
        Task<ValidatedModel<UserPasswordResetModel>> ResetPasswordAsync(UserPasswordResetModel model);
        Task<ValidatedModel<UserPasswordChangeModel>> ChangePasswordAsync(UserPasswordChangeModel model);
    }
}