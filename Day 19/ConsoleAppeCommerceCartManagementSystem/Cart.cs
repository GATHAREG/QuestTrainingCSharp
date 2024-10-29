using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppeCommerceCartManagementSystem
{
    internal class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void Add(CartItem item)
        {
            items.Add(item);
        }
        public void Update(string name ,int quantity,int price)
        {
            var item =items.First(x => x.Name.Trim().ToLower() == name.Trim().ToLower());
            if(item != null)
            {
                item.Quantity = quantity;
                item.Price = price;
                Console.WriteLine("Updated");
            }
           

        }
        public void Remove(string name)
        {
            var item = items.First(x => x.Name.ToLower() == name.ToLower());
            if(item != null)
            {
                items.Remove(item);
                Console.WriteLine("Removed");
            }
           

        }
        public List<CartItem> GetItems()
        {
            return items;
        }
    }
}
