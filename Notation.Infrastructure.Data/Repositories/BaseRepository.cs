using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Notation.Domain.Core.Models.Base;
using Notation.Domain.Intarfaces;

namespace Notation.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IMongoCollection<T> collection;

        public BaseRepository(MongoProvider db)
        {
            collection = db.GetCollection<T>();
        }

        public async Task CreateAsync(T entity) =>
            await collection.InsertOneAsync(entity);

        public async Task DeleteAsync(int id) =>
            await collection.DeleteOneAsync(e => e.Id == id);

        public async Task<T> Get(int id)
        {
            return await collection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await collection
                .Find(Builders<T>.Filter.Empty).ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await collection.ReplaceOneAsync(e => e.Id == entity.Id, entity);
        }
    }
}