namespace Structural_Bridge
{
    public interface IAuthenticator
    {
        IUser Authenticate(IUser user);
    }
}
