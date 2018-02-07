using BargainsUK.DAL.Models;
using BargainsUK.Utils;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BargainsUK.DAL.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly Context _context = null;

        public CurrencyRepository(IOptions<Settings> settings)
        {
            _context = new Context(settings);
        }

        public IList<Currency> GetAll()
        {
            

            return _context.Currencies.Find(_ => true).ToList();
        }

        public async Task<IList<Currency>> GetAllAsync()
        {
            return await _context.Currencies.Find(_ => true).ToListAsync(); ;
        }

        public async Task<Currency> GetByAsync(string id)
        {
            var filter = Builders<Currency>.Filter.Eq("Id", id);
            return await _context.Currencies.Find(filter).FirstOrDefaultAsync();
        }
    }
}
