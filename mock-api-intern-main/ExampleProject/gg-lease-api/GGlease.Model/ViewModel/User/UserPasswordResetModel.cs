namespace GGlease.Model.ViewModel
{
    public class UserPasswordResetModel
    {
        public int Id { get; set; }
        public string Password { get; set; } = null!;
        public string PasswordResetToken { get; set; } = null!;
    }
}
