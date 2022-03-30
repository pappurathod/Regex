using System;
namespace RegularExpession
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine("Enter first name");
            string FirstName=Console.ReadLine();
            userRegistration.validFirstName(FirstName);
        }        
    }
}