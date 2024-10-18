//8: Write a Func<string, int> delegate that takes a string as input and returns the length of the string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
    
    internal class DelegateFour
    {
        public static int LengthOfString(string str) => str.Length;
        static void Main(string[] args)
        {
            Func<string,int> su = LengthOfString;
            Console.WriteLine(su("HELLO WORLD"));
        }
    }
}
