using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectedLiskov
{
    
        
            interface IFlyable
            {
                     void Fly();
              }

        public class Bird
        {
            public string Name { get; set; }
        }

        class Pigeon : Bird, IFlyable
        {
            public void Fly() => Console.WriteLine("Pigeon is flying");
        }

        public class Penguin : Bird
        {
        }
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFax
    {
        void Fax();
    }

    public class Printer : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new Pigeon();
        }


    }
}
