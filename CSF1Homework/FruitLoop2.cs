using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 2");
            Console.Title = "Fruit Loops 2";
            string[] fruits =
                { "Pomegranate", "Banana", "Orange", "Apple", "Grapes", "Pineapple" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);

                for (int i = 0; i < Array.IndexOf(fruits, fruit); i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            } 
        }
    }
}
