using System;
namespace RegularExpession
{
    public class Program
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
                Console.WriteLine("6 for Password at least one Upper case");
                Console.WriteLine("7 for Password at least one Number");
                Console.WriteLine("8 for Password at least one special char");
                Console.WriteLine("9 for Check Email Validation");
                Console.WriteLine("10 for Exit");
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
                        string Password_1 = Console.ReadLine();
                        userRegistration.validPasswordR2(Password_1);
                        break;
                    case 7:
                        Console.WriteLine("Enter Password");
                        string Password_2 = Console.ReadLine();
                        userRegistration.validPasswordR3(Password_2);
                        break;
                    case 8:
                        Console.WriteLine("Enter Password");
                        string Password_3 = Console.ReadLine();
                        userRegistration.validPasswordR4(Password_3);
                        break;
                    case 9:
                        Console.WriteLine("Enter Password");
                        string CheckEmail = Console.ReadLine();
                        userRegistration.validCheckEmailSample(CheckEmail);
                        break;
                    case 10:
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 10);
        }    
    }
}
