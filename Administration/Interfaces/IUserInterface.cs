using Administration.Models;

namespace Administration.Interfaces
{
    public interface IUserInterface
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}
