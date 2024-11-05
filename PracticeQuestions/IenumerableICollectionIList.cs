using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableIcollectionIlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

           
            foreach (var number in numbers)
            {
                Console.WriteLine(number); 
            }
            ICollection<int> numberCollection= new List<int> { 1, 2, 3 };

            numberCollection.Add(4);           
            numberCollection.Remove(2);        
            Console.WriteLine(numberCollection.Count);


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            IList<int> numberList = new List<int> { 1,2,3,4,5 };

            numberList.Add(40);           
            numberList.Insert(1, 15);      
            numberList.RemoveAt(2);
            Console.WriteLine(numberList.Count);
            Console.WriteLine(numberList[1]);
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // Output: 10 15 30 40
            }
        }
    }
}


