using AutoMapper;
using GGlease.Data;
using GGlease.Model.DB;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;

namespace GGlease.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly DataContext dataContext;
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public UserService(DataContext dataContext,
            IAuthService authService,
            IConfiguration configuration,
            IMapper mapper)
        {
            this.dataContext = dataContext;
            this.authService = authService;
            this.mapper = mapper;
        }

        private static string CreateSalt()
        {
            var salt = RandomNumberGenerator.GetBytes(64);
            var strSalt = Convert.ToHexString(salt);

            return strSalt;
        }

        private static string HashPassword(string password, string salt)
        {
            var passwordData = System.Text.Encoding.UTF8.GetBytes(password);
            var saltData = Convert.FromHexString(salt);
            var hash = HMACSHA256.HashData(saltData, passwordData);

            return Convert.ToHexString(hash);
        }

        public async Task<ValidatedModel<UserPasswordResetModel>> ActivateAsync(UserPasswordResetModel model)
        {
            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (user == null || user.PasswordResetToken != model.PasswordResetToken || user.IsActive)
                return new ValidatedModel<UserPasswordResetModel>("Kullanıcı bulunamadı!");

            var salt = CreateSalt();
            var password = HashPassword(model.Password, salt);

            user.Password = password;
            user.Salt = salt;
            user.IsActive = true;
            user.PasswordResetToken = Guid.NewGuid().ToString("N");

            await dataContext.SaveChangesAsync();

            return new ValidatedModel<UserPasswordResetModel>(model);
        }

        public async Task<ValidatedModel<UserPasswordChangeModel>> ChangePasswordAsync(UserPasswordChangeModel model)
        {
            var currentUser = authService.CurrentUser;

            if (currentUser == null)
                return new ValidatedModel<UserPasswordChangeModel>("Kullanıcı bulunamadı!");

            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == currentUser.Id);

            if (user == null)
                return new ValidatedModel<UserPasswordChangeModel>("Kullanıcı bulunamadı!");

            var currentPassword = HashPassword(model.CurrentPassword, user.Salt);

            if (currentPassword != user.Password)
                return new ValidatedModel<UserPasswordChangeModel>("Mevcut şifre hatalı!");

            var salt = CreateSalt();
            var password = HashPassword(model.NewPassword, salt);

            user.Password = password;
            user.Salt = salt;

            await dataContext.SaveChangesAsync();

            return new ValidatedModel<UserPasswordChangeModel>(model);
        }

        public async Task<ValidatedModel<UserDetailModel>> CreateAsync(UserCreateModel model)
        {
            var validation = await ValidateCreateModelAsync(model);
            if (validation != null)
                return new ValidatedModel<UserDetailModel>(validation);

            var role = Model.Enums.UserRole.User;

            if (authService.CurrentUser?.UserRole() == Model.Enums.UserRole.Admin)
                role = Model.Enums.UserRole.Admin;
            else
                role = Model.Enums.UserRole.User;

            var user = new User
            {
                Email = model.Email,
                Name = model.Name,
                PasswordResetToken = Guid.NewGuid().ToString("N"),
                Password = "not-activated",
                Salt = "",
                Role = role
            };

            dataContext.Users.Add(user);
            await dataContext.SaveChangesAsync();
            var result = mapper.Map<UserDetailModel>(user);
            return new ValidatedModel<UserDetailModel>(result);
        }

        private async Task<string?> ValidateCreateModelAsync(UserCreateModel model)
        {
            var userExist = await dataContext.Users.AnyAsync(x => x.Email == model.Email && (x.IsActive || x.Password == "not-activated"));

            if (userExist)
                return "Bu email adresi kayıtlı";

            return null;
        }

        public async Task<ValidatedModel<UserDetailModel>> LoginAsync(UserLoginModel model)
        {
            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Email == model.Email);

            if (user == null || !user.IsActive || user.Salt == "")
                return new ValidatedModel<UserDetailModel>("Kullanıcı bulunamadı");

            var password = HashPassword(model.Password, user.Salt);

            if (password != user.Password)
                return new ValidatedModel<UserDetailModel>("Kullanıcı bulunamadı");

            user.LastLoginTime = DateTime.UtcNow;

            await dataContext.SaveChangesAsync();

            var result = mapper.Map<UserDetailModel>(user);

            return new ValidatedModel<UserDetailModel>(result);
        }

        public async Task<ValidatedModel<UserPasswordResetModel>> ResetPasswordAsync(UserPasswordResetModel model)
        {
            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (user == null)
                return new ValidatedModel<UserPasswordResetModel>("Kullanıcı bulunamadı");

            if (user.PasswordResetTokenExpireDate == null || user.PasswordResetTokenExpireDate.Value < DateTime.UtcNow)
                return new ValidatedModel<UserPasswordResetModel>("Zaman aşımı Yeniden deneyin");

            if (model.PasswordResetToken == "" || user.PasswordResetToken != model.PasswordResetToken)
                return new ValidatedModel<UserPasswordResetModel>("Kullanıcı bulunamadı");

            var salt = CreateSalt();
            var password = HashPassword(model.Password, salt);

            user.Password = password;
            user.Salt = salt;
            user.PasswordResetToken = Guid.NewGuid().ToString("N");
            user.PasswordResetTokenExpireDate = null;
            user.IsActive = true;

            await dataContext.SaveChangesAsync();

            return new ValidatedModel<UserPasswordResetModel>(model);
        }

        public async Task<ValidatedModel<UserPasswordResetRequestModel>> ResetPasswordRequestAsync(UserPasswordResetRequestModel model)
        {
            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Email == model.Email);

            if (user == null)
                return new ValidatedModel<UserPasswordResetRequestModel>("Kullanıcı bulunamadı");

            if (user.PasswordResetTokenExpireDate != null && user.PasswordResetTokenExpireDate.Value > DateTime.UtcNow)
                return new ValidatedModel<UserPasswordResetRequestModel>("Şifre yenileme talebiniz devam ediyor");

            user.PasswordResetTokenExpireDate = DateTime.UtcNow.AddMinutes(5);
            user.PasswordResetToken = Guid.NewGuid().ToString("N");
            await dataContext.SaveChangesAsync();
            return new ValidatedModel<UserPasswordResetRequestModel>(model);
        }

        public async Task<ValidatedModel<UserEditModel>> UpdateAsync(UserEditModel model)
        {
            if (model.Id == authService.CurrentUser?.Id)
                return new ValidatedModel<UserEditModel>("Bu işlemi gerçekleştiremezsiniz");
            var user = await dataContext.Users.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (user == null)
                return new ValidatedModel<UserEditModel>("Kullanıcı bulunamadı");
            var currentUser = authService.CurrentUser!;
            user.IsActive = model.IsActive;
            await dataContext.SaveChangesAsync();
            return new ValidatedModel<UserEditModel>(model);
        }
    }
}
