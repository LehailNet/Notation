using System.Collections.Generic;
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

        public async Task CreateNoteAsync(Note note) =>
            await GetMongoCollection
            .InsertOneAsync(note);

        public async Task DeleteNoteAsync(int id) =>
            await GetMongoCollection.DeleteOneAsync(note => note.Id == id);

        public async Task<Note> GetNote(int id)
        {
            return await GetMongoCollection
            .Find(note => note.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Note>> GetNotes()
        {
            return await GetMongoCollection
            .Find(Builders<Note>.Filter.Empty).ToListAsync();
        }

        public async Task UpdateNoteAsync(Note note) =>
            await GetMongoCollection
            .ReplaceOneAsync(n => n.Id == note.Id, note);

    }
}
