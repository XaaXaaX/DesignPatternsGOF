using System;
namespace Structural_Bridge
{
    public class Authenticator : IAuthenticator
    {
        private readonly IAuthenticationContext authenticationContext;

        public Authenticator(IAuthenticationContext authenticationContext)
        {
            this.authenticationContext = authenticationContext;
        }

        public IUser Authenticate(IUser user)
        {
            if (this.authenticationContext.ValidateUser(user) != null)
            {
                this.authenticationContext.AuthenticateUser(user);
            }

            throw new UnauthorizedAccessException();
        }
    }
}
