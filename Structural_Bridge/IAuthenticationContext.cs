namespace Structural_Bridge
{
    public interface IAuthenticationContext
    {
        IUser AuthenticateUser(IUser user);

        IUser ValidateUser(IUser user);
    }
}