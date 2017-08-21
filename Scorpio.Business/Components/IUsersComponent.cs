using Scorpio.Data;
using System;
using System.Threading.Tasks;

namespace Scorpio.Business.Components
{
    public class LoginUserModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class ChangePasswordModel
    {
        public string Email { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }

    public class ResetPasswordRequestModel
    {
        public string Email { get; set; }
    }

    public class ResetPasswordModel
    {
        public Guid ResetPasswordRequestToken { get; set; }

        public string NewPassword { get; set; }
    }    

    public interface IUsersComponent
    {
        Task<User> Login(LoginUserModel model);

        Task<bool> ChangePassword(ChangePasswordModel model);

        Task<Guid> ResetPasswordRequest(ResetPasswordRequestModel model);

        Task ResetPassword(ResetPasswordModel model);
    }   
}