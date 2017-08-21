using System;
using System.Collections.Generic;

namespace Scorpio.Data
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool PasswordExpired { get; set; }

        public Guid ResetPasswordToken { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}