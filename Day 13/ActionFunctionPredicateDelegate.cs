using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunnctionAndPredicateDelegates
{
    internal class Program
    {
        //static void Message(string msg) => Console.WriteLine(msg);
        //static string Add(int x, int y)=> (x+y).ToString();
        //static bool IsEven(int n)=> n%2==0;

        //Action<string> at = Message;

        //Func<int, int, string> bt = Add;

        //Func<int,bool> a = IsEven;

        //Predicate<int> b = IsEven;
        //at("hello");
        //Console.WriteLine( bt(1, 2));
        //var res = a(1);
        //var res2 = b(1);

          //static bool IsEven(int value) => value %2 == 0;
            //static bool IsNegative(int value) => value < 0;

            // Method to filter data based on the given condition (predicate)
            static void GetDataBasedOnTheCondition(int[] data, Predicate<int> predicate)
            {
                var result = new List<int>();

                foreach (var item in data)
                {
                    if (predicate(item))
                    {
                        result.Add(item);
                    }
                }

                Console.WriteLine(string.Join(", ", result));
            }

            static void Main(string[] args)
            {
                // Array of integers
                var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -3, -5 };

               GetDataBasedOnTheCondition(data, i => i % 2 == 0);

               GetDataBasedOnTheCondition(data, i => i%2 != 0);
              GetDataBasedOnTheCondition(data, i => i*2== i+2);




            // Filter negative numbers
            GetDataBasedOnTheCondition(data, x => x < 0);
            }
        

    }
}
