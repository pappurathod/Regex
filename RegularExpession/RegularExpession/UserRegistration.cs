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
            bool FirstNamePattern(string FirstNamePattern) => FirstNameR.IsMatch(FirstName);
            bool result = FirstNamePattern(FirstName);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "First Name is Invalid");
                }
                return "First Name is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "First Name is Invalid");
            }            
        }
        public string validLastName(string LastName)
        {
            bool LastNamePattern(string LastNamePattern) => LastNameR.IsMatch(LastName);
            bool result = LastNamePattern(LastName);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Last Name is Invalid");
                }
                return "Last Name is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Last Name is Invalid");
            }
        }
        public string validEmail(string Email)
        {
            bool EmailPattern(string EmailPattern) => EmailR.IsMatch(Email);
            bool result = EmailPattern(Email);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "EmailId is Invalid");
                }
                return "EmailId is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "EmailId is Invalid");
            }
        }
        public string validMobileNo(string MobileNo)
        {
            bool MobileNoPattern(string MobileNoPattern) => MobileNoR.IsMatch(MobileNo);
            bool result = MobileNoPattern(MobileNo);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "MobileNo is Invalid");
                }
                return "MobileNo is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "MobileNo is Invalid");
            }          
        }
        public string validPassword(string Password)
        {
            bool PasswordPattern(string PasswordPattern) => PasswordR.IsMatch(Password);
            bool result = PasswordPattern(Password);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
            }
        }
        public string validPasswordR2(string Password2)
        {
            bool PasswordR2Pattern(string PasswordR2Pattern) => PasswordR.IsMatch(Password2);
            bool result = PasswordR2Pattern(Password2);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
            }                    
        }
        public string validPasswordR3(string Password3)
        {
            bool PasswordR3Pattern(string PasswordR3Pattern) => PasswordR.IsMatch(Password3);
            bool result = PasswordR3Pattern(Password3);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
            } 
        }
        public string validPasswordR4(string Password_4)
        {
            bool PasswordR4Pattern(string PasswordR4Pattern) => PasswordR.IsMatch(Password_4);
            bool result = PasswordR4Pattern(Password_4);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
                }
                return "Password is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password is Invalid");
            }
        }
        public string validCheckEmailSample(string CheckEmail)
        {
            bool CheckEmailPattern(string CheckEmailPattern) => CheckEmailR.IsMatch(CheckEmail);
            bool result = CheckEmailPattern(CheckEmail);
            try
            {
                if (result == false)
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid");
                }
                return "Email is valid";
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Email is Invalid");
            }          
        }
    }
}