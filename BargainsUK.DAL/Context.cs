using BargainsUK.DAL.Models;
using BargainsUK.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BargainsUK.DAL
{
    public class Context
    {
        private readonly IMongoDatabase _database = null;

        public Context(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);

            // TEST
            //var collection = _database.GetCollection<BsonDocument>("bullshit");

            var test = 1;
        }

        public IMongoCollection<Currency> Currencies
        {
            get
            {
                return _database.GetCollection<Currency>("currency");
            }
        }
    }
}
