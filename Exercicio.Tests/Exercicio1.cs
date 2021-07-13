using Exercicio1.Interface;
using Exercicio1.Model;
using Exercicio1.Service;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio1
    {
        [Fact]
        public void MultiplosDe35E7()
        {
            INumeroNaturalService service = new NumeroNaturalService();

            Assert.Equal(233168, service.SomaMultiplos(new TresOuCinco()));
            Assert.Equal(33165, service.SomaMultiplos(new TresECinco()));
            Assert.Equal(33173, service.SomaMultiplos(new TresOuCincoESete()));
        }

    }
}
