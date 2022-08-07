using Notation.Domain.Core.Models;

namespace Notation.Infrastructure.Data.Repositories
{
    public class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository(MongoProvider db) : base(db) { }
    }
}
