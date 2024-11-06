using ConsoleAppNoteTaking.Model;
using ConsoleAppNoteTaking.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNoteTaking.View
{
    internal class NoteManagement
    {
        private readonly IStorageNote _storage;

        public NoteManagement(IStorageNote storage )
        {
            _storage = storage;
            
        }

        public void Run()
        {
            while (true)
            {


                Console.WriteLine("WELCOME TO THE NOTE TAKING APPLICATION");
                Console.WriteLine("1.ADD A NEW NOTE");
                Console.WriteLine("2.VIEW ALL NOTE");
                Console.WriteLine("3.UPDATE A NOTE");
                Console.WriteLine("4.DELETE A NOTE");
                Console.WriteLine("5.SEARCH NOTES");
                Console.WriteLine("6.EXIT FROM THE APPLICATION");
                Console.Write("Enter the choice: ");
                var choice = Console.ReadLine().Trim();
                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        GetAll();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Delete();
                        break;
                    case "5":
                        Search();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! plaese try again");
                        break;
                }
            }
            
        }

        public void Search()
        {
            Console.Write("Enter a word to search by title or content: ");
            string word = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("word cannot be empty.");
                return;
            }

            var notes = _storage.SearchNotes(word);
            if (notes == null)
            {
                Console.WriteLine("No  notes found.");
            }
            else
            {
                Console.WriteLine("notes:");
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, Content: {note.Content}, Created At: {note.CreatedAt}");
                }
            }
        }

        public void Delete()
        {
            Console.Write("Enter the id to delete:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var note = _storage.GetById(id);
                if(note != null)
                {
                    Console.Write($"Do you want to delete the note {note.Title} (y/n): ");
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "y")
                    {
                        _storage.Delete(id);
                      
                    }
                    else
                    {
                        Console.WriteLine(" No Deletion ");
                    }
                }
                else
                {
                    Console.WriteLine("Note with that id does not exist");

                }

            }
        }

        public void Update()
        {
            Console.Write("Enter the id to update:");

            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var note = _storage.GetById(id);
                if(note!= null)
                {
                    Console.WriteLine($"Current Title: {note.Title}");
                    Console.WriteLine($"Current Content: {note.Content}");
                    Console.Write("Enter the new  title of note:");
                    Console.Write("Enter new title (leave empty to keep current): ");
                    string newTitle = Console.ReadLine();
                    Console.Write("Enter new content (leave empty to keep current): ");
                    string newContent = Console.ReadLine();

                    
                    note.Title = !string.IsNullOrWhiteSpace(newTitle) ? newTitle : note.Title;
                    note.Content = !string.IsNullOrWhiteSpace(newContent) ? newContent : note.Content;
                    note.UpdatedAt = DateTime.Now;

                    _storage.Update(note);
                }
                else
                {
                    Console.WriteLine("Note with that id does not exist");
                }
            }
        }
         public void GetAll()
         {
            var notes = _storage.GetAll();
            if (notes == null)
            {
                Console.WriteLine("No notes available");
                return;
            }
            foreach(var note in notes)
            {
                Console.WriteLine($"ID:{note.Id}, Title:{note.Title}, Content:{note.Content}, Created At: {note.CreatedAt}");
            }
         }

          public void Add()
          {   
                Console.Write("Enter the title of note:");
                string title = Console.ReadLine().Trim();
                Console.Write("Enter the Content of note:");
                string content = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine("Title and content cannot be empty.");
                    return;
                }
                var note = new Note()
                {
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };

                _storage.AddNote(note);
            

          }
    }
}
