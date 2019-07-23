using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome!\n");
            bool repeat = true;
            while (repeat)
            {

                ValidateUserName(); //use these void methods
                VerifyEmail();
                VerifyPhoneNumber();
                ValidateDate();

                string input = "";
                while (input != "y" && input != "n") //you can use relational and logical operators
                {
                    Console.WriteLine("Would you like to go again? Y/N\n");
                    input = Console.ReadLine().ToLower();
                }


                if (input != "y")
                {
                    Console.WriteLine("\nSee you later, friend!");
                    repeat = false;
                }
                else //y in this case
                {
                    repeat = true;
                }

            }

            Console.ReadKey();
        }

        //method called GetUserInfo
        public static void VerifyPhoneNumber()
        {
            //addConsole.WriteLine("Please enter valid name");
            Console.WriteLine("\nPlease enter a valid phone number.\n");
            string phoneNumber = Console.ReadLine();

            bool works = Regex.IsMatch(phoneNumber, @"^(\d{3})-(\d{3})-(\d{4})$");
            if (works)
            {
                Console.WriteLine("\nThat is a valid phone number.");

            }
            else
            {
                Console.WriteLine("\nThat is an invalid phone number.");
            }

            //^ means beginning of string, $ means ending of string

        }


        public static void VerifyEmail()
        {
            //addConsole.WriteLine("Please enter valid name");
            Console.WriteLine("\nPlease enter a valid email address.\n");
            string input = Console.ReadLine();

            bool works = Regex.IsMatch(input, @"^([a-z]{4,20}@[a-z]{5,11})+.+$");//long thing is the STANDARD for emails
            if (works)
            {
                Console.WriteLine("\nThat is a valid email.");

            }
            else
            {
                Console.WriteLine("\nThat is invalid email.");
            }

            //^ means beginning of string, $ means ending of string

        }



        public static void ValidateUserName()
        {
            Console.WriteLine("Please enter a valid name.\n");
            string input = Console.ReadLine();
            bool match = Regex.IsMatch(input, @"^([A-Z]{1}[a-zA-Z]{1,29})$");

            if (match)
            {
                Console.WriteLine("\nThat is a valid name.\n");

            }
            else
            {
                Console.WriteLine("\nThat is an invalid name.");
            }
        }
        public static void ValidateDate()
        {
            Console.WriteLine("\nPlease enter in a valid date.\n");
            string input = Console.ReadLine();
            bool match =
            Regex.IsMatch(input, @"^([0][1-9]|[1][0-9|][2][0-9]|[3][0-1])\/([0][1-9]|[1][0-2])\/[1-2][0-9][0-9][0-9]");

            if (match)
            {
                Console.WriteLine("\nThat is a valid date and year.\n");

            }
            else
            {
                Console.WriteLine("\nThat is an invalid date.\n");
            }

        }
    }
}
