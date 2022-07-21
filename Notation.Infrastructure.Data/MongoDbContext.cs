using MongoDB.Bson;
using MongoDB.Driver;

namespace Notation.Infrastructure.Data
{
    public class MongoDbContext
    {
        private string _connectionString;

        private MongoClient client;
        private IMongoDatabase database;

        public MongoDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IMongoDatabase GetMongoDatabase()
        {
            if (database != null)
            {
                return database;
            }

            client = new MongoClient(_connectionString);
            database = client.GetDatabase("notation");
            return database;
        }

    }
}
