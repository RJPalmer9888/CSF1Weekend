using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MadLib");
            Console.Title = "MadLib";
            Console.Write("Person: ");
            string person = Console.ReadLine();
            Console.Write("Past tense Verb: ");
            string verb = Console.ReadLine();
            Console.Write("Noun: ");
            string noun = Console.ReadLine();
            Console.Write("Adjective: ");
            string adjective = Console.ReadLine();

            Console.WriteLine($"Walking down the road, {person} is suddenly {verb} by a " +
                $"{noun}, causing him to become totally {adjective}.");
        }
    }
}
