using System;
using Codecademy;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 5;
            string uppercase = "JORDAN";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
            string specialChars = "#, ?, !";

            Console.WriteLine("Please enter a password: ");
            string password = Console.ReadLine();
            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            Console.WriteLine(score);

            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak password");
                    break;
                case 2:
                    Console.WriteLine("Medium strength password");
                    break;
                case 3:
                    Console.WriteLine("Strong password");
                    break;
                case 4:
                    Console.WriteLine("Extremely strong password");
                    break;
                case 5:
                    Console.WriteLine("Extremely strong password");
                    break;
                default:
                    Console.WriteLine("Sorry but your password doesn't meet any of our standards");
                    break;


            }
        }
    }
}
