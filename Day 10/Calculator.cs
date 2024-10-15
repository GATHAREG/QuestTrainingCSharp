// private to make the fields access restrict from outside the class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    internal class Calculator
    {
        private int num1;
        private int num2;

        public void Add()
        {
            Console.WriteLine($"Sum is {num1 + num2}");
        }

        public void Subtract()
        {
            Console.WriteLine($"Difference is { num1 - num2}");
        }

        public void Multiply()
        {
            Console.WriteLine($"Product is {num1 * num2}");
        }

        public void Divide() => Console.WriteLine($"Quotient is {num1 /  num2}");

        public void Run()
        {
            Console.Write("Enter the first number:");
            int num1 = int.Parse( Console.ReadLine() );
            Console.Write("Enter the second number:");
            int num2 = int.Parse( Console.ReadLine() );

            Add();
            Subtract();
            Multiply();
            Divide();
        }


    }
}
