using BargainsUK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BargainsUK.DAL.Repositories
{
    public interface ICurrencyRepository
    {
        IList<Currency> GetAll();
        Task<IList<Currency>> GetAllAsync();

        Currency GetBy(string id);
        Task<Currency> GetByAsync(string id);
    }
}
