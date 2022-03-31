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

        public void validFirstName(string FirstName)
        {

            if (FirstNameR.IsMatch(FirstName))
            {
                Console.WriteLine("{0} First Name is valid", FirstName);
            }
            else
            {
                Console.WriteLine("{0} First Name is not valid", FirstName);
            }
        }
        public void validLastName(string LastName)
        {

            if (FirstNameR.IsMatch(LastName))
            {
                Console.WriteLine("{0} Last Name is valid", LastName);
            }
            else
            {
                Console.WriteLine("{0} Last Name is not valid", LastName);
            }
        }
        public void validEmail(string Email)
        {

            if (EmailR.IsMatch(Email))
            {
                Console.WriteLine("{0} Email is valid", Email);
            }
            else
            {
                Console.WriteLine("{0} Email is not valid", Email);
            }
        }

        public void validMobileNo(string MobileNo)
        {

            if (MobileNoR.IsMatch(MobileNo))
            {
                Console.WriteLine("{0} Mobile Number is valid", MobileNo);
            }
            else
            {
                Console.WriteLine("{0} Mobile Number is not valid", MobileNo);
            }
        }
    }
}