using BargainsUK.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BargainsUK.DAL.Repositories
{
    public interface ICultureRepository
    {
        IList<Culture> GetAll();
        Task<IList<Culture>> GetAllAsync();

        IList<Culture> GetBy(string iso);
        Task<Culture> GetByAsync(string iso);
    }
}
