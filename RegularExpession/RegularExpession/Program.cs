using System;
namespace RegularExpession
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();
            int choice;
            do
            {
                Console.WriteLine("select your choice");
                Console.WriteLine("1 for FirstName");
                Console.WriteLine("2 for LaststName");
                Console.WriteLine("3 for Email");
                Console.WriteLine("4 for MobileNumber");
                Console.WriteLine("5 for Password");
                Console.WriteLine("6 for Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter First name");
                        string fName = Console.ReadLine();
                        userRegistration.validFirstName(fName);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last name");
                        string LastName = Console.ReadLine();
                        userRegistration.validLastName(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        userRegistration.validEmail(Email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number");
                        string MobileNo = Console.ReadLine();
                        userRegistration.validMobileNo(MobileNo);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string Password = Console.ReadLine();
                        userRegistration.validPassword(Password);
                        break;
                    case 6:
                        Console.WriteLine("Enter Password");
                        string Password1 = Console.ReadLine();
                        userRegistration.validPasswordR2(Password1);
                        break;
                    case 7:
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 7);
        }    
    }
}
