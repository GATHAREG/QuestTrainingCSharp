//2: Create an abstract class Vehicle with a property Speed and an abstract method Drive(). Implement the Drive() method in two derived classes Car and Bicycle.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    abstract class Vechicle
    {
        public int speed { get; set; }
        public abstract void Drive();
    }
    class Car : Vechicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving a car with speed {speed}");
        }
    }
    class Bicycle : Vechicle
    {
        public override void Drive()
        {
            Console.WriteLine($"Driving a bicycle with speed {speed}");
        }
    }
    internal class SecondOne
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.speed = 100;
            var  bike = new Bicycle();
            bike.speed = 60;

            car.Drive();
            bike.Drive();
            
        }
    }
}
