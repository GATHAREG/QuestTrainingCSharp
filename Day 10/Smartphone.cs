using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{
    class SmartPhone
    {
        public string Name;
        public string Brand;
        public List<int> Storage;

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name}, {Brand},  memory :{string.Join(",",Storage)}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        { /*
            SmartPhone phone = new SmartPhone();
            phone.Name = "Motog";
            phone.Brand = "Motorola";
            phone.Storage = new List<int>() {  16, 32,64 };

            //recommended way of object declaration and value assigning just like dictionary

            var phone2 = new SmartPhone()
            {
                Name = "Iphone",
                Brand = "Apple",
                Storage =  new List<int> { 16, 32,64 }
            }; */

            var calculator1 = new Calculator();
            while (true)
            {
               calculator1.Run();
                

            }


            



        }
    }
}
