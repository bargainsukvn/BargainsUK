using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BargainsUK.DAL.Models
{
    public class Currency
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("sign")]
        public string Sign { get; set; }

        [BsonElement("name")]
        public string Code { get; set; }
    }
}
