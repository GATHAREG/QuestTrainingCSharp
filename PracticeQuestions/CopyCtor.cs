using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorWorking
{
    public class Car
    {
       public string Brand {  get; set; }

        public Car(string theBrand)
        {
            Brand = theBrand;
        }

        // copy constructor

        public Car(Car c1)
        {
            Brand = c1.Brand;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Swift");
            Console.WriteLine("Make of car1: " + car1.Brand);

            Car car2 = new Car(car1);
            Console.WriteLine("Make of car2: " + car2.Brand);
        }
    }
}

