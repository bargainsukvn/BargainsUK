using BargainsUK.DAL.Models;
using BargainsUK.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;

namespace BargainsUK.DAL
{
    public class Context : IContext
    {
        private readonly IOptions<Settings> _settings;

        public Context(IOptions<Settings> settings)
        {
            if (settings == null)
                throw new ArgumentException("Invalid settings", nameof(settings));

            if (settings.Value == null || string.IsNullOrEmpty(settings.Value.ConnectionString))
                throw new ArgumentException("Invalid settings", nameof(settings.Value));

            _settings = settings;

            //_client = new MongoClient(settings.Value.ConnectionString);
            //if (client == null)
            //    throw new InvalidOperationException($"Invalid connection: {settings.Value.ConnectionString}");
        }

        private IMongoClient _client = null;
        internal IMongoClient Client => _client ?? (_client = new MongoClient(_settings.Value.ConnectionString));

        private IMongoDatabase _database = null;
        private IMongoDatabase Database => _database ?? (_database = Client.GetDatabase(_settings.Value.Database));

        public virtual IMongoCollection<Currency> Currencies => Database.GetCollection<Currency>("currency");

        public virtual IMongoCollection<Culture> Cultures => Database.GetCollection<Culture>("culture");
    }
}
