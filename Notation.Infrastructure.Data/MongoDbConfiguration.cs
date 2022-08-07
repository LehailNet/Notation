namespace Notation.Infrastructure.Data
{
    public class MongoDbConfiguration
    {
        public static string SectionName => "MongoDB";
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
