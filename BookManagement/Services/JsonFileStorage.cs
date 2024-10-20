using BookManagement.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    internal class JsonFileStorage : IStorageService
    {
        private readonly string storageDirectory;

        public JsonFileStorage()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            storageDirectory = Path.Combine(documentPath,"Books", "jsonData");
            Directory.CreateDirectory(storageDirectory);    
        }
        public void Delete(string id)
        {
            var filePath = Path.Combine(storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public Book GetById(string id)
        {
            return default;
        }

        public void Save(Book book)
        {
            var  jsontext = JsonConvert.SerializeObject(book);
            var filePath = Path.Combine(storageDirectory,$"{book.Id}.json");
            File.WriteAllText(filePath, jsontext);
        }

        public Book Search(string title)
        {
            var files = Directory.GetFiles(storageDirectory);
            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);
                Book book = JsonConvert.DeserializeObject<Book>(fileContent);
                var titleOfBook = book.Title.ToLower();
                var tileTosearch = title.ToLower();

                if (titleOfBook.Contains(tileTosearch))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
