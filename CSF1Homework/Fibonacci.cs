using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            Console.Title = "Fibonacci";
            Console.Write("Enter a number: ");
            int end = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int temp = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (b < end)
            {
                temp = b;
                b = b + a;
                a = temp;
                if (b < end)
                {
                    Console.WriteLine(b);
                }
                
            }
        }
    }
}
