using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops 1");
            Console.Title = "Fruit Loops 1";
            string[] fruits =
                { "Pomegranate", "Banana", "Orange", "Apple", "Grapes", "Pineapple" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            } 
        }
    }
}
