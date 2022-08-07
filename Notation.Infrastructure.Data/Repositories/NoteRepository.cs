using Notation.Domain.Core.Models;

namespace Notation.Infrastructure.Data.Repositories
{
    public class NoteRepository : BaseRepository<Note>
    {
        public NoteRepository(MongoProvider db) : base(db) { }
    }
}
