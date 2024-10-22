using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class SortedList<T>
    {
        private List<T> _data = new List<T>();
        public int Count => _data.Count;

        public void Add(T data)
        {
            _data.Add(data);
            _data.Sort();

        }
    }
    class NewDictionary<T, tvalue>
    {
        private Dictionary<T, tvalue> _data = new Dictionary<T, tvalue>();
        public int Count => _data.Count;
        public void Add(T key,tvalue value)
        {
            _data.Add(key,value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberList = new SortedList<int>();
            numberList.Add(1);
            numberList.Add(2);

            var stringList = new SortedList<string>();
            stringList.Add("hello");

            var dict = new NewDictionary<int, string>();
            dict.Add(1,"One");
            dict.Add(2, "Two");
        }
    }
}
