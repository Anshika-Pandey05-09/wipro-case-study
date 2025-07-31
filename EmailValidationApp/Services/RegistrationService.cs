using EmailValidationApp.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidationApp.Services
{
    public class RegistrationService
    {
        private readonly EmailValidator _validator;

        public RegistrationService(EmailValidator validator)
        {
            _validator = validator;
        }

        public string Register(string email)
        {
            if (_validator.IsEmailValid(email))
            {
                return "Registration successful.";
            }
            return "Invalid email address.";
        }
    }

}
