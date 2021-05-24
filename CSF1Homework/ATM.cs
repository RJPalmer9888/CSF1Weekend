using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            int wrongU = 0;
            int wrongP = 0;
            int account;
            int pin;
            bool test1 = true;
            bool test2 = true;
            while (test1)
            {
                Console.WriteLine("ATM");
                Console.Title = "ATM";
                Console.Write("Enter your Account Number: ");
                account = Int32.Parse(Console.ReadLine());

                if (account == 72490)
                {

                    test1 = false;
                }

                else
                {
                    Console.WriteLine("Incorrect account");
                    wrongU++;
                    Console.WriteLine($"{3 - wrongU} attempts remaining");
                }

                if (wrongU == 3)
                {
                    test1 = false;
                }
            }
            Console.Clear();
            if (wrongU < 3)
            {
                while (test2)
                {
                    Console.WriteLine("Logging in to Account 72490");
                    Console.Write("Enter your password: ");
                    pin = Int32.Parse(Console.ReadLine());

                    if (pin == 1234)
                    {
                        Console.Clear();
                        Console.WriteLine("Access Granted");
                        test2 = false;
                        bool repeatMenu = true;
                        decimal balance = 300.00m;
                        do
                        {
                            Console.WriteLine("Welcome to ATM Services.\n" +
                                "Please choose an option:\n" +
                                "D)eposit \n" +
                                "W)idthdrawal \n" +
                                "B)alance \n" +
                                "Esc) to exit");
                            ConsoleKey userChoice = Console.ReadKey().Key;
                            Console.Clear();


                            switch (userChoice)
                            {
                                case ConsoleKey.D:
                                    Console.Write("Enter your deposit amount: $");
                                    balance += decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Deposit Successful. \nYour current " +
                                        $"balance is {balance:c}");
                                    break;


                                case ConsoleKey.W:
                                    Console.Write("Enter your widthdrawal amount: $");
                                    decimal widthdrawal = decimal.Parse(Console.ReadLine());
                                    if (widthdrawal < balance)
                                    {
                                        balance -= widthdrawal;
                                        Console.WriteLine("Widthdrawal Successful. \nYour current " +
                                            $"balance is {balance:c}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Insufficient funds.");
                                    }

                                    break;

                                case ConsoleKey.B:
                                    Console.WriteLine($"Your current balance is {balance:c}");
                                    break;


                                case ConsoleKey.Escape:
                                    Console.WriteLine("Thank you for using this ATM");
                                    repeatMenu = false;
                                    break;

                                default:
                                    Console.WriteLine("That was an invalid option.");
                                    break;
                            }

                        } while (repeatMenu);
                    }

                    else
                    {
                        Console.WriteLine("Incorrect pin");
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
