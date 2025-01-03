using GGlease.Model.Enums;

namespace GGlease.Model.ViewModel
{
    public class UserDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;

        public UserRole UserRole() => Enum.Parse<UserRole>(Role);

    }
}
