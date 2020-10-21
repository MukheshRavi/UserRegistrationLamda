using System;
using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    public class UserValidate
    {
        /// <summary>
        /// This method is to Take input from user and validate entered name
        /// </summary>
        /// <returns></returns>
        public static bool ValidateName()
        {
            ///Takes input from user
            Console.WriteLine("Enter First Name : start with capital and min 3 characters");
            string name = Console.ReadLine();
            String pattern = "^[A-Z][a-zA-Z0-9]{2}";
            Regex regex = new Regex(pattern);
            ///Lamda expression to validate
            Func<string,bool> ValidateName = (name) => regex.IsMatch(name);
            {
               ///If user enters Correct name then returns true
                Console.WriteLine("Valid name entered");
                return true;
            }
        }

        /// <summary>
        /// This method is to Take input from user and validate entered email
        /// </summary>
        /// <returns></returns>
        public static bool ValidateEmail()
        {
            ///Takes input from user
            Console.WriteLine("Enter mail id");
            string email = Console.ReadLine();
            String emailPattern = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
            ///Lamda expression to validate
            Func<string, bool> ValidateName = (email) => regex.IsMatch(email);
            {
                ///If user enters Correct email then returns true
                Console.WriteLine("Valid email entered");
                return true;
            }
        }
        /// <summary>
        /// This method is to Take input from user and validate entered phone Number
        /// </summary>
        /// <returns></returns>

        public static bool ValidatePhoneNumber()
        {
            ///Takes input from user
            Console.WriteLine("Enter Phone Number");
            string phnNo = Console.ReadLine();
            String phnPattern = "^[9][1][ ][6-9]([0-9]{9})$";
            Regex regex = new Regex(phnPattern);
            ///Lamda expression to validate
            Func<string, bool> ValidateName = (phnNo) => regex.IsMatch(phnNo);
            {
                ///If user enters correct Phone Number then returns true
                Console.WriteLine("Valid Phone Number entered");
                return true;
            }
        }
        /// <summary>
        /// This method is to Take input from user and validate entered Password
        /// </summary>
        /// <returns></returns>
        public static bool ValidatePassword()
        {
            ///Takes input from user
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            String passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
            ///Lamda expression to validate
            Func<string, bool> ValidateName = (password) => regex.IsMatch(password);
            {
                ///If user enters Correct Password then returns true
                Console.WriteLine("Valid Password entered");
                return true;
            }
        }
    }
}
