using Notation.Domain.Core.Models;
using Notation.Domain.Intarfaces;
using Notation.Services.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using System;

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

            note.TimeCreate = DateTime.Now;

            await _repository.CreateAsync(note);
        }

        public async Task DeleteNoteAsync(Note note)
        {
            await _repository.DeleteAsync(note.Id);
        }
    }
}
