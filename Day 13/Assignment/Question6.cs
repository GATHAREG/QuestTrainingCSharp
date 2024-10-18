//6: Create a delegate PrintMessage that takes a string as a parameter. Write a method DisplayMessage that prints the string passed to it. Use the delegate to call DisplayMessage.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectDelegates
{
  
    internal class DelegateTwo
    {

        delegate void PrintMessage(string message);
        public static void DisplayMessage(string msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            PrintMessage p = DisplayMessage;
            p("Good morning");
        }

    }
}
