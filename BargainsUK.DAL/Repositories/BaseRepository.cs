using BargainsUK.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BargainsUK.DAL.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly IContext _context = null;

        public BaseRepository(IContext context)
        {
            _context = context;
        }
    }
}
