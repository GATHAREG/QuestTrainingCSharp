using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPhoneBook.Repository
{
   
    internal class Storage : IStorageService

    {
        const string connString = @"Data Source = GATHA\SQLEXPRESS;Database = QuestDb; Integrated Security = True";


        public void Add(Contact contact)
        {
            var conn = new SqlConnection(connString);
            conn.Open();

            var insertQ = $"INSERT INTO Contacts(name, phonenumber,email) VALUES(@name, @phonenumber, @email)";
            var command = new SqlCommand(insertQ, conn);
            command.Parameters.AddWithValue("@name", contact.Name);
            command.Parameters.AddWithValue("@phonenumber", contact.PhoneNumber);
            command.Parameters.AddWithValue("@email", contact.Email);
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void Remove(string name)
        {
            var conn = new SqlConnection(connString);
            conn.Open();
            var query = $"Delete from contacts where name =name";
            var command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
            conn.Close();

        }

        public void Search(string input)
        {
            var conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command;


            var query = $"SELECT phoneNumber, name, email FROM contacts WHERE phoneNumber = @phonenumber OR name LIKE @name";
            command = new SqlCommand(query, conn);
            if(int.TryParse(input,out int phoneNumber))
            {
                command.Parameters.AddWithValue("@phonenumber", phoneNumber);
            }
            else
            {
                command.Parameters.AddWithValue("@phonenumber", DBNull.Value);
            }
            command.Parameters.AddWithValue("@name", "%" + input + "%");
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var phonenumber = reader.GetInt32(0); ;
                var name = reader.GetString(1);
                var email = reader.GetString(2);


                Console.WriteLine($"{phonenumber} = {name} ,{email}");
            }
            conn.Close();
        }

        public void Update(string name, int number, string email)
        {
            var conn = new SqlConnection(connString);
            conn.Open();
            var query = $"UPDATE  CONTACTS SET phoneNumber = @phonenumber, Email = @Email where name= @name";
            var command = new SqlCommand (query, conn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phonenumber", number);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
