using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "Szarath" || password != "Szarath115")
            {
                throw new Exception("Invalid username or password.");
            }
        }
    }
}