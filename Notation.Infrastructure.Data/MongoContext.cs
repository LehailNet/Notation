using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Notation.Infrastructure.Data
{
    public class MongoContext
    {
        AppSettings AppSettings { get; }

        private IMongoDatabase database { get; set; }

        public MongoContext(IOptions<AppSettings> options)
        {
            AppSettings = options.Value;

            GetDatabase();
        }

        public IMongoCollection<T> GetCollection<T>() where T : class
        {
            return database.GetCollection<T>(typeof(T).Name);
        }

        private IMongoDatabase GetDatabase()
        {
            var connection = new MongoUrlBuilder(AppSettings.ConnectionString);
            MongoClient client = new MongoClient(AppSettings.ConnectionString);

            database = client.GetDatabase(connection.DatabaseName);
            return database;
        }

    }
}
