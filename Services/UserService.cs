using ProcessRUs.DTOs;
using ProcessRUs.Entities;
using ProcessRUs.Helpers;
using ProcessRUs.Interfaces;
using System.Security.Claims;

namespace ProcessRUs.Services
{
    public class UserService: IUserService
    {
        private readonly IdentityHelper _identityHelper;
        public UserService(IdentityHelper identityHelper)
        {
            _identityHelper = identityHelper;
        }

        public LoginResponse Login(UserInfo userLogin)
        {
            var user = _identityHelper.AuthenticateUser(userLogin);

            if (user == null) return null;

            var token = _identityHelper.GenerateToken(user);
            var response = new LoginResponse { Token = token };
            return response;
        }
    }
}
