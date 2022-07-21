using Notation.Domain.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface INoteRepository
    {
        Task CreateNote(Note note);

        Note GetNote(int id);

        void UpdateNote(Note note);

        void DeleteNote(int id);

        IEnumerable<Note> GetNotes();
    }
}
