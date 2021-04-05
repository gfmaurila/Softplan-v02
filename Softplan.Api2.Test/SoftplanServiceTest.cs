using Softplan.Service.Services;
using Xunit;

namespace Softplan.Api2.Test
{
    public class SoftplanServiceTest
    {
        private readonly SoftplanService _service;
        public SoftplanServiceTest()
        {
            _service = new SoftplanService();
        }

        [Fact]
        public void CalculaJuros()
        {
            var resultado = _service.CalculaJuros(100,5);
            Assert.Equal(101, resultado.ValorFinal);
        }
    }
}
