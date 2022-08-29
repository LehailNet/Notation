using Notation.Domain.Core.Models;
using System.Threading.Tasks;

namespace Notation.Services.Interfaces
{
    public interface INoteServices
    {
        Task CreateNoteAsync(Note note);
    }
}
