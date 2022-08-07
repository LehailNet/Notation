using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;

namespace Notation.Infrastructure.Data
{
    public class MongoProvider
    {
        private IMongoDatabase Database { get; set; }

        public MongoProvider(IOptions<MongoDbConfiguration> options)
        {
            if (options.Value == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            MongoClient client = new MongoClient(options.Value.ConnectionString);
            Database = client.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>() where T : class => 
            Database.GetCollection<T>(typeof(T).Name);
    }
}
