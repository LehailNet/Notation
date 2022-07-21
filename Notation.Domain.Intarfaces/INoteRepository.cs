using Notation.Domain.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface INoteRepository
    {
        Task CreateNoteAsync(Note note);

        Note GetNote(int id);

        Task UpdateNoteAsync(Note note);

        Task DeleteNoteAsync(int id);

        IEnumerable<Note> GetNotes();

    }
}
