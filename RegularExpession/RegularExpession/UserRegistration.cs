using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpession
{
    public class UserRegistration
    {
        public Regex FirstNameR = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex LastNameR = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex EmailR = new Regex(@"^[a-z]{3,}([.]{1}[a-z]{3,})?@bl.co([.]{1}[a-z]{2})?$");
        public Regex MobileNoR = new Regex(@"^[0-9]{2}[ ][6-9]{1}[0-9]{9}$");
        public Regex PasswordR = new Regex(@"^[a-zA-Z0-9]{8,}$");
        public Regex PasswordR2 = new Regex(@"^(?=.*[A-Z])[a-zA-Z0-9]{8,}$");
        public Regex PasswordR3 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$");
        public Regex PasswordR4 = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9]{8,}$");
        public Regex CheckEmailR = new Regex(@"^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$");       

        public string validFirstName(string FirstName)
        {
            if (FirstNameR.IsMatch(FirstName))
                return "First Name is valid";           
            else 
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME,"");
        }
        public string validLastName(string LastName)
        {
            if (FirstNameR.IsMatch(LastName))
                return "Last Name is valid";
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "");
        }
        public string validEmail(string Email)
        {
            if (EmailR.IsMatch(Email))
                return "EmailId is valid";
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "");
        }
        public string validMobileNo(string MobileNo)
        {
            if (MobileNoR.IsMatch(MobileNo))
                return "MobileNo is valid";
            else throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER," ");          
        }
        public string validPassword(string Password)
        {
            if (PasswordR.IsMatch(Password))
                return "Password is valid";
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "");
        }
        public void validPasswordR2(string Password2)
        {
            if (PasswordR2.IsMatch(Password2))            
                Console.WriteLine("{0} Password is valid", Password2);            
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "");                    
        }
        public void validPasswordR3(string Password3)
        {
            if (PasswordR3.IsMatch(Password3))            
                Console.WriteLine("{0} Password is valid", Password3);            
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "");                  
        }
        public void validPasswordR4(string Password_4)
        {
            if (PasswordR4.IsMatch(Password_4))            
                Console.WriteLine("{0} Password is valid", Password_4);            
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "");           Console.WriteLine("{0} Password is not valid", Password_4);
        }
        public string validCheckEmailSample(string CheckEmail)
        {
            if (CheckEmailR.IsMatch(CheckEmail))
                return "Email is valid";
            else
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "");            
        }
    }
}