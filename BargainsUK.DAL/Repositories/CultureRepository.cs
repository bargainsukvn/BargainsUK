using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BargainsUK.DAL.Models;
using BargainsUK.Utils;
using Microsoft.Extensions.Options;

namespace BargainsUK.DAL.Repositories
{
    public class CultureRepository : BaseRepository, ICultureRepository
    {
        public CultureRepository(IContext context) : base(context)
        {
        }

        IList<Culture> ICultureRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        async Task<IList<Culture>> ICultureRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        IList<Culture> ICultureRepository.GetBy(string iso)
        {
            throw new NotImplementedException();
        }

        async Task<Culture> ICultureRepository.GetByAsync(string iso)
        {
            throw new NotImplementedException();
        }
    }
}
