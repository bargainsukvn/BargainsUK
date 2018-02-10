using BargainsUK.DAL;
using BargainsUK.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace BargainsUK.IntegrationTest.Fixture
{
    public class BaseFixture<TService, TImplementation> : IDisposable
        where TService: class
        where TImplementation : class, TService
    {
        private readonly TService _subject;

        public BaseFixture()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var settings = Options.Create(new Settings(config));
            var constructor = typeof(TImplementation).GetConstructor(new[] { typeof(IContext) });
            _subject = (TService)constructor.Invoke(new[] { new Context(settings) });
        }

        public TService Subject => _subject;

        public void Dispose()
        {
        }
    }
}
