using Notation.Domain.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface INoteRepository
    {
        Task CreateNoteAsync(Note note);

        Task<Note> GetNote(int id);

        Task UpdateNoteAsync(Note note);

        Task DeleteNoteAsync(int id);

        Task<IEnumerable<Note>> GetNotes();

    }
}
