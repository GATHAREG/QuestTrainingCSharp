using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValueRferenceType
{
    
    public class MyClass
    {
        public string Data { get; set; }
    }

    internal class Program
    {
        static void ChangeDataRefType(MyClass obj) => obj.Data = "New Data";

        static void ChangeDataValueType(int i) => i = 10;

        static void Main(string[] args)
        {
            var obj = new MyClass() { Data = "Old Data" };
            Console.WriteLine($"Before Reference Type Change: {obj.Data}");
            ChangeDataRefType(obj);
            Console.WriteLine($"After Reference Type Change: {obj.Data}");

            int i = 5;
            Console.WriteLine($"Before Value Type Change: {i}");//5
            ChangeDataValueType(i);
            Console.WriteLine($"After Value Type Change: {i}");//5 copy is passing in value type
        }

        
}

}
