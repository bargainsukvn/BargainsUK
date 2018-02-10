using BargainsUK.DAL.Repositories;
using System;

namespace BargainsUK.Business
{
    public class CulturalResolver
    {
        private readonly ICultureRepository _cultureRepo;
        private readonly ICurrencyRepository _currencyRepo;

        public CulturalResolver(ICultureRepository cultureRepo, ICurrencyRepository currencyRepo)
        {
            _cultureRepo = cultureRepo;
            _currencyRepo = currencyRepo;
        }
    }
}
