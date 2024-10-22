using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    internal class Program
    {
        const string connString = @"Data Source = GATHA\SQLEXPRESS;Database = QuestDb; Integrated Security = True";
        static void Main(string[] args)
        {

            //var createTableQuery = @"CREATE TABLE BOOKS
            //                      (
            //                          id INT PRIMARY KEY IDENTITY,
            //                          name VARCHAR(50),
            //                          author VARCHAR(50),
            //                          price INT

            //                     )";

            ////var insertQuery = @"INSERT into Books(name,author,price) values ('Book 1','X',1200)";
            //Console.Write("Name: ");
            //var name = Console.ReadLine();

            //Console.Write("Author: ");
            //var author = Console.ReadLine();

            //Console.Write("Price: ");
            //var price = Console.ReadLine();

            //var insertQuery = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
            ////var nameParameter = new SqlParameter("@name", name);
            ////var authorParameter = new SqlParameter("@author", author);
            ////var priceParameter = new SqlParameter("@price", price);

            ////insert way

            //var conn = new SqlConnection(connString);
            //conn.Open();

            ////var command = new SqlCommand(insertQuery, conn);

            ////command.Parameters.AddWithValue("@name", name);
            ////command.Parameters.AddWithValue("@author", author);
            ////command.Parameters.AddWithValue("@price", price);

            ////command.ExecuteNonQuery();
            //conn.Close();
            //using (var conn2 = new SqlConnection(connString))
            //{

            //}
            ////select statement execution
            //var Query = $"SELECT id, name, author, price from Books";

            //var connn = new SqlConnection(connString);
            //conn.Open();

            //var commandd = new SqlCommand(Query, connn);
          //  var reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    var id = reader.GetInt32(0);
            //    var namee = reader.GetString(1);
            //    var value = reader.GetString(2);
            //    var pricee = reader.GetInt32(3);

            //    Console.WriteLine($"{id} = {namee} - {value} = {pricee}");
            //}
            //Qusetion to insert a list of books

            var list = new List<Books>()
            {
                new Books{Name = "Book2",Author = "Author 2",Price = 2000},
                 new Books { Name = "Book3", Author = "Author3", Price = 150 },
                 new Books { Name = "Book4", Author = "Author4", Price = 250 },
                new Books { Name = "Book5", Author = "Author5", Price = 300 },
                new Books { Name = "Book6", Author = "Author6", Price = 500 },


            };
            var connect = new SqlConnection(connString);
            connect.Open();
            foreach (var item in list)
            {
                var insertQ = $"INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
                var command = new SqlCommand(insertQ, connect);
                command.Parameters.AddWithValue("@name", item.Name);
                command.Parameters.AddWithValue("@author", item.Author);
                command.Parameters.AddWithValue("@price", item.Price);
                command.ExecuteNonQuery();
               
            }
           connect.Close();


        }
    }
}
