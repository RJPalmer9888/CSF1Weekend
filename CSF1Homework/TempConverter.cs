using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Temperature Converter");
                Console.Title = "Temperature Converter";
                Console.WriteLine("Choose an operation:\n" +
                "C)elsius to Fahrenheit\n" +
                "F)ahrenheit to Celsius");
                ConsoleKey userChoice = Console.ReadKey().Key;

                Console.Clear();
                float cel = 0;
                float fah = 0;
                switch (userChoice)
                {
                    case ConsoleKey.C:
                        Console.Write("Enter temperature in Celsius: ");
                        cel = Single.Parse(Console.ReadLine());
                        fah = (cel * (9.0f / 5.0f) + 32);
                        Console.WriteLine($"{cel}C\u00B0 is equal to {fah}F\u00B0");
                        break;

                    case ConsoleKey.F:
                        Console.Write("Enter temperature in Fahrenheit: ");
                        fah = Single.Parse(Console.ReadLine());
                        cel = ((fah - 32) / (9.0f / 5.0f));
                        Console.WriteLine($"{fah}F\u00B0 is equal to {cel}C\u00B0");
                        break;

                    default:
                        Console.WriteLine("Incorrect option selected");
                        break;
                }
                Boolean go = true;
                while (go)
                {
                    Console.WriteLine("Convert another?:\n" +
                   "Y)es\n" +
                   "N)o");
                    ConsoleKey gogo = Console.ReadKey().Key;



                    switch (gogo)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            go = false;
                            break;

                        case ConsoleKey.N:
                            Console.Clear();
                            Console.WriteLine("Thanks for using us!");
                            go = false;
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid response");
                            break;
                    }
                }
            }
        }
    }
}
