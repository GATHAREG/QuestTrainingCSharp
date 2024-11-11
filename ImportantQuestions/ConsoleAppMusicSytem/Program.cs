using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppMusicSytem
{

    class Music
    {
        private readonly string _path = @"C:\Users\Gatha Reghunath\Desktop\Music";
        private List<string> files;
        private int _index = 0;
        public Music()
        {
            files = new List<string>(Directory.GetFiles(_path));

        }
        public void Start()
        {

            Console.WriteLine($"Started palying:{FileName(_index)}");

        }
        public void Stop()
        {
            Console.WriteLine($"Stopped playing:{FileName(_index)}");
        }
        public void Next()
        {
            _index = (_index == files.Count - 1) ? 0 : _index + 1;

            Console.WriteLine($"playing next:{FileName(_index)}");
        }
        public void Previous()
        {
            _index = (_index == 0) ? files.Count - 1 : _index - 1;

            Console.WriteLine($"playing previous:{FileName(_index)} ");
        }
        public string FileName(int index)
        {
            var filename = Path.GetFileNameWithoutExtension(files[index]);
            return filename;
        }

        //     public void Filter(string word)
        //     {
        //        if(word == null)
        //        {
               // throw  new  ArgumentNullException(nameof(word));
        //        }
          //       if(filter == " ")
        //          {
                        //_filteredFiles.AddRange(files);
                        //return;

        //          }
        ////        word = word.ToLowerInvariant();
        //        var _filteredFiles = files.Where(f =>
        //        {
        //            var fileName = Path.GetFileNameWithoutExtension(f).ToLowerInvariant();
        //            return fileName.Contains(word);

        //        }).ToList();




        //     }
        public void Filter(string word)
        {
           
            var filteredFiles = files.Where(f => Path.GetFileName(f).ToLower().Contains(word.ToLower())).ToList();

            if (filteredFiles.Any())  
            {
               
                int matchingIndex = files.IndexOf(filteredFiles.First());
                Console.WriteLine($"Playing the file with '{word}' its name: {FileName(matchingIndex)}");
                _index = matchingIndex; 
            }
            else if (word == " ")
            {
                Start();  
            }
            else
            {
                Console.WriteLine("No such file to filter");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var music = new Music();
            while(true)
            {
                Console.WriteLine("Music system");
                Console.WriteLine("1.Start");
                Console.WriteLine("2.Stop");
                Console.WriteLine("3.Next");
                Console.WriteLine("4.Previous");
                Console.WriteLine("5.Filter");
                Console.WriteLine("6.Exit");

                Console.Write("Enter the option: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        music.Start();
                        break;
                    case "2":
                        music.Stop();
                        break;
                    case "3":
                        music.Next();
                        break;
                    case "4":
                        music.Previous();
                        break;
                    case "5":
                        Console.Write("Enter the word to search:");
                        string word = Console.ReadLine();
                        music.Filter(word);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option! try again");
                        break;

                }
            }
        }
    }
}
