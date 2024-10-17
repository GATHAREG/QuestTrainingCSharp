using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndFiles
{
    
    internal class Program
    {
        public enum ConverTo
        {
            uppercase,
            lowercase
        }
        public static void ConvertCasting(string input, ConverTo Targettype)
        {
            switch(Targettype)
            {
                case ConverTo.uppercase:
                    Console.WriteLine(input.ToUpper());
                    break;
                case ConverTo.lowercase:
                    Console.WriteLine(input.ToLower());
                    break;
            }

        }
        static void Main(string[] args)
        {
            //ConvertCasting("hello",ConverTo.uppercase);
            //FILE HANDLING

            var path = @"C:\Users\Gatha Reghunath\Documents\FileHandling";
            var fileName = "data.txt;";
            var filePath = Path.Combine(path, fileName);
            //Directory.CreateDirectort(path);
           // File.WriteAllText(filePath, "This is the line");
            //File.AppendAllText(filePath, "this is another line");
            //Directory.Delete(path);
            //Directory.Delete(path,true);

            var content = File.ReadAllText(filePath);

            Console.WriteLine(content); 

            string[] contentLines = File.ReadAllLines(filePath);
            Console.WriteLine(string.Join(",",contentLines));


        }
    }
}
