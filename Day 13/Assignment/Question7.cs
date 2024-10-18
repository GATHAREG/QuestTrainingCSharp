
// 7: Define a Func<int, int, int> delegate that takes two integers as parameters and returns their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
    internal class DelegateThree
    {
        public static int Add(int a, int b) => a + b;
        static void Main(string[] args)
        {
            Func<int, int, int> s = Add;
            Console.WriteLine(s(18,19));
        }
    }
}
