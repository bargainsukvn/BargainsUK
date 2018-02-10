using BargainsUK.DAL.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BargainsUK.DAL
{
    public interface IContext
    {
        IMongoCollection<Currency> Currencies { get; }
        IMongoCollection<Culture> Cultures { get; }
    }
}
