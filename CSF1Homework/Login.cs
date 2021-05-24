using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            int wrongU = 0;
            int wrongP = 0;
            string userName;
            string passWord;
            bool test1 = true;
            bool test2 = true;
            while (test1)
            {
                Console.WriteLine("Login");
                Console.Title = "Login";
                Console.Write("Enter your user name: ");
                userName = Console.ReadLine().ToUpper();

                if (userName == "RYAN")
                {
                    Console.WriteLine("Welcome, Ryan");
                    test1 = false;
                }

                else
                {
                    Console.WriteLine("Incorrect username");
                    wrongU++;
                    Console.WriteLine($"{3 - wrongU} attempts remaining");
                }

                if (wrongU == 3)
                {
                    test1 = false;
                }
            }
            if (wrongU < 3)
            {
                while (test2)
                {
                    Console.Write("Enter your password: ");
                    passWord = Console.ReadLine().ToUpper();

                    if (passWord == "GUARDIAN")
                    {
                        Console.WriteLine("Access Granted");
                        test2 = false;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect password");
                        wrongP++;
                        Console.WriteLine($"{3 - wrongP} attempts remaining");
                    }

                    if (wrongP == 3)
                    {
                        test2 = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

        }
    }
}
