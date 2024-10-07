using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CollectionsAndObjects
{
    internal class Program
    {
        // The concept of object  and its type Type.
          static void DoThis(object a, object b)
          {
              //Type t1 = a.GetType();
              //Type t2 = typeof(string);
              if (a.GetType() == typeof(string))
              {
                  string s1 = (string)a;
                  string s2 = (string)b;
                  Console.WriteLine(s1 + " " + s2);
              }
              else if (a.GetType() == typeof(int))
              {
                  int i1 = (int)a;
                  int i2 = (int)b;
                  Console.WriteLine(i1 + i2);
              }
          } 

        static void Main(string[] args)
        {
             DoThis(1, 2);
              DoThis("Hello", "World");
              string s = "hello";
              Console.WriteLine(s.GetType());
              Console.WriteLine(typeof(string));
              Console.WriteLine(); 
            // collection type list anf its properties

            List <int> lst = new List <int>();
             //var lst = new List<int>();

             //add a single element
             lst.Add (10);

             //Add multiple elements
             var valuesToAdd = new int[] {20,30,40,50,50};
             lst.AddRange (valuesToAdd);

             //change or update an item
             lst[0] = 100;

             //Remove  an element
             //it will remove the first occurance of it
             lst.Remove (50);

             //Remove at from specific index
             lst.RemoveAt(1);

             //To display
             for(int i = 0; i < lst.Count; i++)
             {
                 Console.Write(lst[i]+ ",");
             }
             Console.WriteLine();

             foreach (var item in lst)
             {
                 Console.Write(item + " ,");
             }
             
           // Display a list by removing all even numbers entered by user
             var list = new List <int> ();

              for (int i = 0; i < 5; i++)
              {
                  Console.WriteLine("Enter the number:");
                  list.Add (int.Parse(Console.ReadLine()));
              }
              //always recommend to use the copy of it in foreach

              for(int i = 0;i<list.Count;i++)
              {
                  if (list[i]%2 == 0)
                  {
                      list.RemoveAt(i);
                  }
              }
              //printing the list
              foreach (var item in list)
              {
                  Console.Write(item + ",");

              } 
            // [1,2,3],
            // [2,3,4]
            // [3,4,5]
            // [6,7,8]
            // [8,9,10]
            //just like this  store the mark of three subjects of 2 students.
            //list of list concept is used.

            var data = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                List<int> Marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter the mark of student {i } in {j} subject:");
                    int mark = int.Parse(Console.ReadLine());
                    Marks.Add(mark);
                }
                data.Add(Marks);
            }
            //displaying the mark
           foreach(var Marks in data)
            {
                Console.WriteLine($"The mark of students are:");
                foreach(var Mark in Marks)
                {
                    Console.WriteLine(Mark);
                }
                Console.WriteLine();    
            }




        }

       
    }
}
