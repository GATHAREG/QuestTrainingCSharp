using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Program
    {
        static void DoThis(out int  num)
        {
            num = 0;
        }
        static void DoThat( string s)
        {
            s = "hi";
        }

        static bool TrimToFive(ref string data)
        {
            if(data.Length >5)
            {
                data = data.Substring(0,5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //int number ;
            DoThis(out int number);
            Console.WriteLine(number);

            string str = "hlo";
            DoThat( str);
            Console.WriteLine(str);

            string text = "old data";
            if(TrimToFive(ref text))
            {
                Console.WriteLine(text +"...");
            }
            else
            {
                Console.WriteLine(text);
            }
            //Convert.ToInt32 AND int.Parse
            string s = null;
            int res = Convert.ToInt32(s);
            int ress = int.Parse(s);
            Console.WriteLine(ress);

            Console.WriteLine(res);
           
                string st = "5 ";
                if (int.TryParse(s, out int result))
                {
                    Console.WriteLine(res);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            




        }
    }
}
