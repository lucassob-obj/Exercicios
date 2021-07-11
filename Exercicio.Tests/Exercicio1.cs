using System;
using Utils;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio1
    {
        [Theory(DisplayName = "Verifica multiplos de 3, 5 e 7")]
        [InlineData(false, true, false, 233168)]
        [InlineData(false, true, true, 33165)]
        [InlineData(true, false, true, 33173)]
        public void MultiplosDe35E7(bool numero3, bool numero5, bool numero7, int resultado)
        {
            int soma = Multiplos.SomaMultiplos(numero3, numero5, numero7);
            Assert.Equal(resultado, soma);
        }
    }
}
