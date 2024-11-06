using ConsoleAppNoteTaking.Repository;
using ConsoleAppNoteTaking.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNoteTaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noteRepository = new NoteRepository();
            var noteMangement = new NoteManagement(noteRepository);
            noteMangement.Run();
        }
    }
}
