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
    public class CurrencyRepository : BaseRepository, ICurrencyRepository
    {
        public CurrencyRepository(IContext context) : base(context)
        {
        }

        IList<Currency> ICurrencyRepository.GetAll()
        {
            return _context.Currencies.Find(_ => true).ToList();
        }

        async Task<IList<Currency>> ICurrencyRepository.GetAllAsync()
        {
            return await _context.Currencies.Find(_ => true).ToListAsync(); ;
        }

        Currency ICurrencyRepository.GetBy(string id)
        {
            var filter = Builders<Currency>.Filter.Eq("Id", id);
            return _context.Currencies.Find(filter).FirstOrDefault();
        }

        async Task<Currency> ICurrencyRepository.GetByAsync(string id)
        {
            var filter = Builders<Currency>.Filter.Eq("Id", id);
            return await _context.Currencies.Find(filter).FirstOrDefaultAsync();
        }
    }
}
