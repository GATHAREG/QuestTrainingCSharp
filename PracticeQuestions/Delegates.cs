using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegatesProblem
{
    internal class Program
    {
        static int calculation(int x, int y, Func<int,int,int> Method) => Method(x, y);

        static  Action<int,int> Operation;

        static void Multiply(int a, int b) => Console.WriteLine( a * b);
        static void Power(int a, int b) => Console.WriteLine(Math.Pow(a,b));

        
        static void Main(string[] args)
        {
            //Func<int,int,int> Add  = (x, y) => x + y;
            Func<int,int,int> Sub = (x, y) => x - y;

            Console.WriteLine(calculation(10,5,(x,y)=> x + y));
            Console.WriteLine(calculation(10,5,Sub));

            Operation = Multiply;
            Operation += Power;
            Operation(2,3); 

        }
    }
}
