/*
Inventory Management System for a Store
You are asked to build a simple inventory management system for a store to track product stock and prices.
Requirements:
Use a dictionary to store product details:
Key: Product ID (unique for each product).
Value: A dictionary containing:
"Name" (string): The product name.
"Price" (decimal): The price of the product.
"Stock" (int): The current stock of the product.
Implement the following functions:
AddProduct: Add a new product to the inventory.
UpdateStock: Update the stock quantity for a product.
GetProductDetails: Retrieve product information based on the product ID.
GetLowStockProducts: Return a list of products that have stock below a certain threshold.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Program
    {
       static Dictionary<int, Dictionary<string, object>> inventory = new Dictionary<int, Dictionary<string, object>>();

    
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nINVENTORY MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateStock();
                        break;
                    case 3:
                        GetProductDetails();
                        break;
                    case 4:
                        GetLowStockProducts();
                        break;
                    case 5:
                        return;
                    default:
                        break;
                }


            } 
        }

        private static void GetLowStockProducts()
        {
            Console.Write("Enter the threshold value of stock : ");
            int threshold = int.Parse(Console.ReadLine());
            foreach(var item in inventory)
            {
                var invent = item.Value;
                int quantity = (int)invent["Stock"];
                if (quantity < threshold)
                {
                    Console.WriteLine($"Product ID: {item.Key}, Name: {invent["Name"]}, Stock: {invent["Stock"]}");

                }
            }
        }

        public static void GetProductDetails()
        {
            Console.Write("Enter the product id : ");
            int id = int.Parse(Console.ReadLine());
            if (inventory.ContainsKey(id))
            {
                var product = inventory[id];
                Console.WriteLine($"\nProduct ID: {id}");
                Console.WriteLine($"Name: {product["Name"]}");
                Console.WriteLine($"Price: {product["Price"]}");
                Console.WriteLine($"Stock: {product["Stock"]}");
            }

        }

        public static void UpdateStock()
        {
            Console.Write("Enter the product id that you want to update the stock: ");
            int id = int.Parse(Console.ReadLine());
            if (inventory.ContainsKey(id))
            {
                Console.Write("Enter the new stock quantity :");
                int stock = int.Parse(Console.ReadLine()) ;
                var invent = inventory[id];
                invent["Stock"]= stock;
                Console.WriteLine("Stock updated successfully");


            }
        }
        public static void AddProduct()
        {
            Console.Write("Enter the product id: ");
            int id = int.Parse(Console.ReadLine());
           

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
           
            Console.Write("Enter the product price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            
            Console.Write("Enter the current stock: ");
            int stock = int.Parse(Console.ReadLine());


            inventory.Add(id, new Dictionary<string, object>
            {
                { "Name", name },
                { "Price", price },
                { "Stock", stock }
            });

            Console.WriteLine("product added");

        }
    }
}
