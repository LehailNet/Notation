using Notation.Domain.Core.Models;

namespace Notation.Infrastructure.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(MongoProvider db) : base(db) { }
    }
}
