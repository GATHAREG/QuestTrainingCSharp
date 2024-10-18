//4: Write an interface ICalculator that has methods Add(int a, int b) and Subtract(int a, int b). Implement this interface in a SimpleCalculator class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    interface ICalculator
    {
        void Add(int a,int b);
        void Subtract(int a,int b);
    }
    class SimpleCalculator : ICalculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum is {a+b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"The difference is {a-b}");
        }
        public void Multiply(int a,int b)=>Console.WriteLine($"product is {a*b}");
        public void Divide(int a,int b)=>Console.WriteLine($"Quotient iis {a/b} {b}");
    }
    internal class FourthOne
    {
        static void Main(string[] args)
        {
            var cal = new SimpleCalculator();
            cal.Add(10, 12);
            cal.Subtract(18, 10);
            cal.Multiply(10,12);
            cal.Divide(12, 3);
            
        }
    }
}
