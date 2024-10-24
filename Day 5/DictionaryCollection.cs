using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Dictionary<string,string> d = new Dictionary<string,string>();
           /* var dt = new Dictionary<string, string>()
             {
                 "first name": "gatha"

             };*/

             //dictionary and its properties

            var d = new Dictionary<string, string>();
            //Adding a new value
            d.Add("First NAME", "GATHA");
            d.Add("Last Name ", "Regh");

            //Acessing a value
            Console.WriteLine(d["First NAME"]);

            //Update a value
            d["First NAME"] = "Geetha";
            Console.WriteLine(d["First NAME"]);

            //Remove a value
            d.Remove("Last Name");
            d.Add("Age", "34");
            //Checking if the key exists
            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists");
            }
            else
            {
                Console.WriteLine("key doesn't exist");
            }


            //display
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
          
          //Question: User wants to store the marks of 3 subjects until the user enters q to exit. when user enters q 
          // display the mark of subjects student wise and also enables a search option to find the id and its values
          //assignment to upload in github

            var datas = new Dictionary<string, List<int>>();

            // setting id as key and marks as values


            while (true)
            {
                Console.Write("Enter the Student id or q to exit:");
                string id = (Console.ReadLine());
                if (id == "q")
                {
                    break;
                }
                else
                {
                    if (datas.ContainsKey(id))
                    {
                        Console.Write("Do you want to keep the marks of the existing id ?.(Y/N):");
                        string c = Console.ReadLine().Trim().ToLower();
                        if (c == "y")
                        {
                            continue;
                        }
                    }
                    var marks = new List<int>();
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write($"Enter the mark for subject{j}:");
                        marks.Add(int.Parse(Console.ReadLine()));
                    }
                    datas[id] = marks;
                }
            }    
            
            //displaying them

            foreach(var item in datas)
            {
                Console.Write($"The mark of student id {item.Key}:");
                foreach (var mark in item.Value )
                {
                    Console.Write($"{mark} , ");
                }
                Console.WriteLine();   
            }
            // search for an id 
            
            Console.WriteLine();
            Console.Write("Enter the id to search:");
            string ids = Console.ReadLine();
            if (datas.ContainsKey(ids))
            {
                Console.Write($"The mark of student {ids}:");
                foreach (var item in datas[ids])
                {
                    Console.Write($"{item} ,");
                }
            }

            Console.ReadKey();
        }
    }
}
