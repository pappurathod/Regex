using System;
namespace RegularExpession
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter First name");
            string FirstName=Console.ReadLine();
            userRegistration.validFirstName(FirstName);

            Console.WriteLine("Enter Last name");
            string LastName = Console.ReadLine();
            userRegistration.validLastName(LastName);

            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            userRegistration.validEmail(Email);
        }        
    }
}