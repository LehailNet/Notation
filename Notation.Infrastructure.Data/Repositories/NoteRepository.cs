using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Notation.Domain.Core.Models;
using Notation.Domain.Intarfaces;

namespace Notation.Infrastructure.Data.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly MongoDbContext _db;

        public NoteRepository(MongoDbContext db)
        {
            _db = db;
        }

        // it's method will same for each repository exept model
        private IMongoCollection<Note> GetMongoCollection =>
            _db
            .GetMongoDatabase()
            .GetCollection<Note>("note");

        public async Task CreateNote(Note note)
        {
            await GetMongoCollection
                .InsertOneAsync(note);
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
