//3: Create an interface IAnimal with a method Speak(). Implement the interface in two classes Dog and Cat, each providing their own implementation of Speak().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    interface IAnimal
    {
        void Speak();
        
    }
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog speaks through bark");
        }
    }
    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Cat speaks throw meow");
        }
    }
    internal class ThirdOne
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            var cat = new Cat();
            dog.Speak();
            cat.Speak();
        }
    }
}

