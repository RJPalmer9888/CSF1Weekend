using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            string scores = "";
            Console.WriteLine("Test Scores");
            Console.Title = "Test Scores";
            Boolean positive = true;
            while (positive)
            {

                Console.Write("What was your test result? ");
                int result = Int32.Parse(Console.ReadLine());
                if (result >= 0)
                {
                    scores = scores + result + "\n";
                }
                else
                {
                    positive = false;
                }

            }
            Console.WriteLine("Your Results:\n" + scores);


        }
    }
}
