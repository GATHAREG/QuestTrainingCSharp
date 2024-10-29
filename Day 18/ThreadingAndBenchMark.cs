using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    //public class ArrayAndSpan
    //{
    //    [Benchmark]
    //    public void TestList()
    //    {
    //        var lst = new List<int>();
    //        for (int i = 0; i < 500; i++)
    //        {
    //            lst.Add(i);
    //        }
    //    }

    //    [Benchmark]
    //    public void TestArray()
    //    {
    //        var arr = new int[500];
    //        for (int i = 0; i < 500; i++)
    //        {
    //            arr[i] = i;
    //        }
    //    }
    //}

    internal class Program
    {
        static void Action1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("hello from action1");

        }
        static void Action2()
        {
            Console.WriteLine("hello from action2");
        }
        static void Main(string[] args)
        {
            //Action1();
            //Action2();
            var t1 = new Thread(Action1);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Completed");

        }
        //Debugging
               var s = "This is a     string";
               string[] dataa = s.Split(',');
              for (int i = 0; i < dataa.Length; i++)
              {
                      Console.WriteLine(dataa[i]);
              }
    }
}
