using BargainsUK.DAL.Models;
using System.Threading.Tasks;
using Xunit;

namespace BargainsUK.IntegrationTest
{
    public class CurrencyRepositoryTest : IClassFixture<CurrencyFixture>
    {
        private readonly CurrencyFixture _fixture;

        public CurrencyRepositoryTest(CurrencyFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void GetAll_Returns4()
        {
            var currencies = _fixture.Subject.GetAll();
            Assert.Equal(4, currencies.Count);
            bool Check(Currency c, string sign, string code) => c.Sign == sign && c.Code == code;
            Assert.Contains(currencies, c => Check(c, "$", "USD"));
            Assert.Contains(currencies, c => Check(c, "vnd", "VND"));
            Assert.Contains(currencies, c => Check(c, "£", "Pound"));
            Assert.Contains(currencies, c => Check(c, "€", "EUR"));

        }

        [Fact]
        public async Task GetAllAsync_Returns4()
        {
            var currencies = await _fixture.Subject.GetAllAsync();
            Assert.Equal(4, currencies.Count);
            bool Check(Currency c, string sign, string code) => c.Sign == sign && c.Code == code;
            Assert.Contains(currencies, c => Check(c, "$", "USD"));
            Assert.Contains(currencies, c => Check(c, "vnd", "VND"));
            Assert.Contains(currencies, c => Check(c, "£", "Pound"));
            Assert.Contains(currencies, c => Check(c, "€", "EUR"));
        }

        [Fact]
        public void GetBy_InvalidId_ReturnsNull()
        {
            var _invalidId = "546c776b3e23f5f2ebdd3b03";
            var currency = _fixture.Subject.GetBy(_invalidId);
            Assert.Null(currency);
        }

        [Theory]
        [InlineData("5a78e1c3d459f612b8499bbd")]
        [InlineData("5a78e1dad459f612b8499bbe")]
        [InlineData("5a78e212d459f612b8499bbf")]
        [InlineData("5a78e231d459f612b8499bc0")]
        public void GetBy_ValidId_Returns(string id)
        {
            var currency = _fixture.Subject.GetBy(id);
            Assert.NotNull(currency);
        }

        [Theory]
        [InlineData("5a78e1c3d459f612b8499bbd")]
        [InlineData("5a78e1dad459f612b8499bbe")]
        [InlineData("5a78e212d459f612b8499bbf")]
        [InlineData("5a78e231d459f612b8499bc0")]
        public async Task GetByAsync_ValidId_Returns(string id)
        {
            var currency = await _fixture.Subject.GetByAsync(id);
            Assert.NotNull(currency);
        }
    }
}
