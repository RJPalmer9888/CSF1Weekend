using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interest Calculator");
            Console.Title = "Interest Calculator";
            Console.Write("Enter your initial balance: $");
            decimal balance = Decimal.Parse(Console.ReadLine());
            decimal initial = balance;
            Console.Write("What is your annual interest rate? " +
                "(As decimal, no percentage symbol): ");
            decimal interest = decimal.Parse(Console.ReadLine());
            Console.Write("How many years will you accrue interest?: ");
            int years = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                balance = balance * (1 + interest);
            }
            Console.Clear();
            Console.WriteLine("After {0} year{1}, your {2:c} " +
                "will have grown to {3:c}.",
                years,
                years == 1 ? "" : "s",
                initial,
                balance);
        }
    }
}
