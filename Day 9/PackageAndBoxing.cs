using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "HiHelloHowAreYou?";
            var dt = DateTime.Now-TimeSpan.FromDays(365);
            Console.WriteLine(text.Humanize());
            Console.WriteLine(dt.Humanize());
            int i = 10;
            //boxing
            object obj = i;
            //unboxing
            int j = obj;


        }
    }
}  

 