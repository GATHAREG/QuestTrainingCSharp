using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryShared
{
    public class AppSettings
    {
        protected void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    public class Calculator:AppSettings
    {
        public  Calculator() {
            Add(1,2);
        }
    }
}
