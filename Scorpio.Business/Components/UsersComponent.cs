using Scorpio.Data;
using System;
using System.Threading.Tasks;

namespace Scorpio.Business.Components
{
    public class UsersComponent : IUsersComponent
    {
        public async Task<User> Login(LoginUserModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ChangePassword(ChangePasswordModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> ResetPasswordRequest(ResetPasswordRequestModel model)
        {
            throw new NotImplementedException();
        }

        public async Task ResetPassword(ResetPasswordModel model)
        {
            throw new NotImplementedException();
        }
    }
}