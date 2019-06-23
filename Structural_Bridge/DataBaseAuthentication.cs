using System;
namespace Structural_Bridge
{
    public class DataBaseAuthentication : IAuthenticationContext
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
