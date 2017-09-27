using System;
using Xunit;
using static Scorpio.Business.Models.FluentApi;

namespace Scorpio.Business.Tests
{
    public class FormTests
    {
        [Fact]
        public void LoginPage()
        {
            var loginPage = FormPage("Login",
                TextField("userName", "User Name").Required(),
                PasswordField("password", "Password").Required(),
                CheckBox("rememberMe", "Remember me"),
                SubmitButton("loginButton", "Login")
            );
        }

        [Fact]
        public void ChangePasswordPage()
        {
            var changePasswordPage = FormPage("Change Password",
                PasswordField("oldPassword", "Old Password").Required(),
                PasswordField("newPassword", "New Password").Required(),
                PasswordField("confirmPassword", "Confirm Password").Required(),
                SubmitButton("changePasswordButton", "Change Password"),
                CancelButton("cancelButton", "Cancel")
            );
        }

        [Fact]
        public void OrderPage()
        {
            var orderPage = FormPage("Order",
                FormGroup("billingAddress", "Billing Address",
                    TextField("addressLine1", "Street").Required(),
                    TextField("addressLine2", ""),
                    TextField("city", "City"),
                    TextField("state", "State"),
                    TextField("zip", "Zip")),
                FormGroup("shippingAddress", "Shipping Address")
            );
        }
    }
}