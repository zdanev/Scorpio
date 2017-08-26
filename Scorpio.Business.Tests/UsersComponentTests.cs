using System;
using Xunit;
using static Scorpio.Business.Models.FluentApi;

namespace Scorpio.Business.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var loginPage = FormPage("Login",
                TextField("User Name", "userName").Required(),
                PasswordField("Password", "password").Required(),
                CheckBox("Remember me", "rememberMe"),
                SubmitButton("Login", "loginButton")
            );

            var changePasswordPage = FormPage("Change Password",
                PasswordField("Old Password", "oldPassword").Required(),
                PasswordField("New Password", "newPassword").Required(),
                PasswordField("Confirm Password", "confirmPassword").Required(),
                SubmitButton("Change Password", "changePasswordButton"),
                CancelButton("Cancel", "cancelButton")
            );
        }
    }
}