//9: Define an Action<string> delegate that prints a string to the console. Use this delegate to call a method that prints a welcome message.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
    internal class ActionDelegate
    {
        public static void Display(string msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            Action<string> a = Display;
            a("Hello Welcome");
        }
    }
}
//10: Create an Action<int, int> delegate that takes two integers and prints their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
    internal class ActionDelegateTwo
    {
        public static void Add(int a, int b) => Console.WriteLine(a + b);
        static void Main(string[] args)
        {
            Action<int, int> sum = Add;
            sum(6, 7);
        }

    }
}
