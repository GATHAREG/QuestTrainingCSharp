//11: Write a Predicate<int> that checks if a given integer is even.
//12: Create a Predicate<string> that checks if a given string starts with the letter 'A'.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
    internal class PredicateOne
    {
        static void Main(string[] args)
        {
            // 11th question
            Predicate<int> p = (i => i % 2 == 0);
            Console.WriteLine(p(10));

            //12 th question
            Predicate<string> str = (s => s.StartsWith("A"));
            Console.WriteLine(str("Anyway"));

        }
       

    }
}



 
