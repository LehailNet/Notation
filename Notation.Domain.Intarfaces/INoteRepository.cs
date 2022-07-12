using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    internal interface INoteRepository
    {
        Task CreateNote(Note note);

        Note GetNote(int id);

        void UpdateNote(Note note);

        void DeleteNote(int id);

        IEnumerable<Note> GetNotes();
    }
}
