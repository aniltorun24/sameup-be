using GGlease.Model.Enums;

namespace GGlease.Model.DB
{
    public class User
    {
        public User()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public string? PasswordResetToken { get; set; }
        public DateTime? PasswordResetTokenExpireDate { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
    }
}
