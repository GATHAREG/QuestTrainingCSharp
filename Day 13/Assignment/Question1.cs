//1: Define an abstract class called Shape with an abstract method Area(). Create two derived classes Circle and Rectangle that implement the Area() method for calculating the area of the respective shapes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    //1.Abstract class
    abstract class Shape
    {
        public abstract void Area();
        
    }
    class Circle : Shape
    {
        public int Radius {  get; set; }
        public Circle(int _radius)
        {
            Radius = _radius;
            
        }
        public override void Area()
        {
            Console.WriteLine($"Area is : {3.14 * Radius * Radius}");
        }
    }
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int _width,int _height)
        {
            Width = _width;
            Height = _height;
            
        }

        public override void Area()
        {
            Console.WriteLine($"Area is : {Height*Width}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(4);
            var rectangle = new Rectangle(10, 12);

            circle.Area();
            rectangle.Area();
        }
    }
}
