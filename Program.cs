using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationLamda
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///calling validate methods to validate user entries
            UserValidate.ValidateName();
            UserValidate.ValidateEmail();
            UserValidate.ValidatePhoneNumber();
            UserValidate.ValidatePassword();
           
        }
    }
}
