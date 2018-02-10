using Microsoft.Extensions.Configuration;
using System;

namespace BargainsUK.Utils
{
    public class Settings
    {
        public Settings() { }

        public Settings(IConfiguration config)
        {
            ConnectionString = config.GetSection("MongoConnection:ConnectionString").Value;
            Database = config.GetSection("MongoConnection:Database").Value;
        }

        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
