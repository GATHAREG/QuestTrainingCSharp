//13: Define an abstract class Appliance with an abstract method TurnOn(). Create a derived class Fan that implements the TurnOn() method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectAbstractAndVirtual
{
    internal class Program
    {
        abstract class Appliance
        {
            public abstract void TurnOn();
        }
        class Fan:Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine(" Fan is turned on");
            }
        }
        static void Main(string[] args)
        {
            var fan = new Fan();
            fan.TurnOn();
        }
    }
}


//14: Create an abstract class Person with an abstract method Work(). Implement Work() in derived classes Doctor and Engineer to describe their specific jobs.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjectAbstractAndVirtual
{
    abstract class Person
    {
        public abstract void Work();
    }
    class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("The job of Doctor is patient treatment");
        }
    }
    class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("The job of Engineer is to solve problems");
        }
    }
    internal class AbstractTwo
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor();
            doctor.Work();
            var engineer = new Engineer();
            engineer.Work();
        }
    }
}

