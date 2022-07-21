using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Notation.Domain.Core.Models;
using Notation.Domain.Intarfaces;

namespace Notation.Infrastructure.Data.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly DbContext _db;

        public NoteRepository()
        {

        }


        public Task CreateNote(Note note)
        {
            throw new NotImplementedException();
        }

        public void DeleteNote(int id)
        {
            throw new NotImplementedException();
        }

        public Note GetNote(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetNotes()
        {
            throw new NotImplementedException();
        }

        public void UpdateNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
