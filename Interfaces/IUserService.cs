using ProcessRUs.DTOs;

namespace ProcessRUs.Interfaces
{
    public interface IUserService
    {
        LoginResponse Login(UserInfo userLogin);
    }
}
