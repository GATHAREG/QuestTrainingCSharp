using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCircleAndPerimeter
{
    /*Design two classes:
   Circle (with a Radius property)
   Rectangle (with Length and Width properties)
   Each class should have methods:
   double GetArea(): to calculate the area of the shape.
   double GetPerimeter(): to calculate the perimeter of the shape.
  Store the shapes in a single list and then display the area and  perimeter of the shapes stored.*/
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double Getperimeter();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double Getperimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Width {  get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
            
        }

        public override double Getperimeter()
        {
           return 2*(Width + Height);
        }
    }
    internal class Program
   {  

    static void Main(string[] args)
    {
        var shape = new List<Shape>()
        {
            new Circle{Radius = 10.0},
            new Rectangle{Width = 10.0, Height = 10.0}

        };

        foreach(var item in shape)
        {
            Console.WriteLine(item.GetArea());
            Console.WriteLine(item.Getperimeter());
        }
       

       
        

       
    }
    }
}

