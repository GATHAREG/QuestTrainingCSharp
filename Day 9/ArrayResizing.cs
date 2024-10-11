using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResizing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {1,2,3,4,5};

            var arr2 = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            foreach (int i in arr2)
            {
                Console.Write(i+ " ");
            }


            Console.ReadKey();
        }
    }
}
