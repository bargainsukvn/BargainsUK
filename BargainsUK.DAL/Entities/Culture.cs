using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace BargainsUK.DAL.Models
{
    public class Culture
    {
        [BsonId]
        public string Id { get; set; }

        public string Iso { get; set; }
        public string Desc { get; set; }
    }
}
