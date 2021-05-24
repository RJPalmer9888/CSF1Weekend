using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            Console.Title = "FizzBuzz";
            Console.Write("Enter a number: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i < end; i++)
            {
                bool check = true;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    check = false;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    check = false;
                }
                if (check != false)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
    }
}
