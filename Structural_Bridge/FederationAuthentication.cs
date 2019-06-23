using System;
namespace Structural_Bridge
{
    public class FederationAuthentication : IAuthenticationContext
    {
        public IUser AuthenticateUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser ValidateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
