using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        class ShoppingList
        {
            // private string[] _items = new string[10];
            private List<string> _items = new List<string>();

            //public string this[int index]
            //{
            //    get { return _items[index]; }
            //    set { _items[index] = value; }
            //}

            //public int TotalItems => _items.Count(x => x != null);

            public string this[int index]
            {
                get
                {

                    if (index >= _items.Count)
                    {
                        throw new IndexOutOfRangeException("Index Out of Range");
                    }
                    return _items[index];
                }
                set
                {

                    if (index >= _items.Count)
                    {
                        _items.Add(value);
                    }
                    else
                    {
                        _items[index] = value;
                    }

                }
            }

            public int TotalItems => _items.Count;
        }

        static void Main(string[] args)
        {
            // var lst = new ShoppingList();
            // //lst[] = "orange";
            // // lst.Add("apple");

            //// lst.Add("Orange");
            // Console.WriteLine(lst.TotalItems);
            try
            {
                var shoppingList = new ShoppingList();
              //  Console.WriteLine(shoppingList[10]);
                Console.WriteLine(shoppingList.TotalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
