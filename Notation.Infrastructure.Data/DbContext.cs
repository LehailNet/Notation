using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Notation.Infrastructure.Data
{
    public class DbContext
    {
        private IConfiguration _configuration;
        private MongoClient _client;
        private IMongoDatabase _database;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MongoClient GetMongoClient ()
        {
            if (_client != null)
                return _client;

            _client = new MongoClient (_configuration.GetConnectionString("MongoDb"));
            return _client;

        }
    }
}
