using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Powers of Two");
            Console.Title = "Powers";
            //For loop, powers of 2 from 1 to 50
            long value = 2;
            Console.WriteLine($"2^1: {value}");
            for (int i = 1; i < 50; i++)
            {
                value *= 2;
                Console.WriteLine($"2^{i+1}: {value}");
            }
        }
    }
}
