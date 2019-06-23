namespace Structural_Bridge
{
    public interface IUser
    {
        string UserName { get; set; }

        string Email { get; set; }

        UserRole Role { get; set; }
    }
}