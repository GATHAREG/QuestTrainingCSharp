using ConsoleAppNoteTaking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNoteTaking.Repository
{
    internal interface IStorageNote
    {
        void AddNote(Note note);

        List<Note> GetAll();
        List<Note> SearchNotes(string word);

        Note GetById(int id);

        void Update(Note note);

        void Delete(int id);

        
    }
}
