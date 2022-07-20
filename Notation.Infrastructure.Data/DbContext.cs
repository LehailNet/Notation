using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace Notation.Infrastructure.Data
{
    public class DbContext
    {
        private MongoClient _client;
        private IConfiguration _configuration;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MongoClient GetClient ()
        {
            if (_client != null)
                return _client;

            _client = new MongoClient (_configuration.GetConnectionString("MongoDb"));
            return _client;

        }
    }
}
