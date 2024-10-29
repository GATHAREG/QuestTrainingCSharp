using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CultureInfoO
{
    internal class Program
    {
        static void Action1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"Action 1: {DateTime.Now}");
        }

        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-IN");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            Console.WriteLine($"Main: {DateTime.Now}");

            var t = new Thread(Action1);
            t.Start();
            var c = new CultureInfo("en-US");
            var price = 100;
            var formattedPrice = price.ToString("c", c); //FORMAT WITH $ DUE TO US
            var fp = price.ToString("F2"); //POINT 2
            var fpp = price.ToString("D6"); //000123
            var fppp = price.ToString("G6"); //123.768    123.8
            var fff = price.ToString("N"); // COMMA SEPARATED
            Console.WriteLine(formattedPrice);


        }
    }
}
