using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{  class A
    {
        public string DataA { get; set; }

        public void MethodA()
        {
            Console.WriteLine("This is a method A");
        }
    }
    class B : A
    {
        public string DataB { get; set; }
        public void MethodB()
        {
            Console.WriteLine("This is method B");

        }
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("This is Method A in B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            b.MethodB();
            b.MethodA(); // This will call method a in both
        }
    }
}
