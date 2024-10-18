using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class StudentBase
    {
        public string Name { get; set; }
        public virtual void Display() => Console.WriteLine(Name);
    }

    class Student : StudentBase
    {
        public string Grade { get; set; }
        public override void Display()
        {
            Console.WriteLine(Name + " " + Grade);
        }
    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Student { Name = "John", Grade = "A" };
            s.Display();

        }
    }
}

