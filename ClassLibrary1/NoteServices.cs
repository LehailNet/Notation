using Notation.Domain.Core.Models;
using Notation.Domain.Intarfaces;
using Notation.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NoteServices : INoteServices
    {

        private readonly IBaseRepository<Note> _repository;

        public NoteServices(IBaseRepository<Note> repository)
        {
            _repository = repository;
        }

        public async Task CreateNoteAsync(Note note)
        {
            Thread.Sleep(4000);
            await _repository.CreateAsync(note);
        }
    }
}
