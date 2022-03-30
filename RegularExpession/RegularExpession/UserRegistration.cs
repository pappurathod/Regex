﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpession
{
    public class UserRegistration
    {
        public Regex FirstNameR =new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex LastNameR = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public void validFirstName(string FirstName)
        {
            
            if (FirstNameR.IsMatch(FirstName))
            {
                Console.WriteLine("{0} First Name is valid",FirstName);
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
    }
}
