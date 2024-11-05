using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCustomException
{
    class MyCustomException : Exception
    {
        public string Message {  get; set; }
        public MyCustomException(string message) 
        {
            Message = message;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Enter the num1:");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the num2:");
                int num2 = int.Parse(Console.ReadLine());
                if(num2 == 0)
                {
                    throw new MyCustomException("Second number can't be zero");
                }
                Console.WriteLine(num1/num2);
            }
            catch(MyCustomException e)
            {
                Console.WriteLine(e.Message);
            }







        }
    }
}
//Read all text from file using async
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsyncFile
{
    internal class Program
    {
        static async Task<string> ReadAll(string path)
        {
            await Task.Delay(100);
             return File.ReadAllText(path);
          
        }

        static async Task Main(string[] args)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"File.txt");
            try
            {
                string content = await ReadAll(filePath);
                Console.WriteLine(content);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }
    }
}

