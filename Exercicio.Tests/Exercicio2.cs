using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio2
    {
        [Theory(DisplayName = @"Um número não é feliz quando, em seu processo de cálculo, 
            em algum momento ele entra em loop, ou seja, ele passe por um número que ele já passou anteriormente")]
        [InlineData(1, true)]
        [InlineData(7, true)]
        [InlineData(10, true)]
        [InlineData(13, true)]
        [InlineData(19, true)]
        [InlineData(23, true)]
        public void NumeroFeliz(int numero, bool resultado)
        {
            bool verifica = Utils.NumeroFeliz.VerificarNumero(numero);

            Assert.Equal(resultado, verifica);
        }

        [Theory(DisplayName = @"Um número é feliz quando, a soma recorrente de seus digitos ao quadrado resulta em 1.")]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(3, false)]
        [InlineData(4, false)]
        [InlineData(5, false)]
        [InlineData(6, false)]
        [InlineData(8, false)]
        public void NumeroNaoFeliz(int numero, bool resultado)
        {
            bool verifica = Utils.NumeroFeliz.VerificarNumero(numero);

            Assert.Equal(resultado, verifica);
        }

        [Theory(DisplayName = @"Deve ser considerado apenas números inteiros positivos.")]
        [InlineData(-1, false)]
        [InlineData(-2, false)]
        [InlineData(-3, false)]
        [InlineData(-4, false)]
        [InlineData(-5, false)]
        public void NumeroNaturalValido(int numero, bool resultado)
        {
            bool verifica = Utils.NumeroFeliz.VerificarNumero(numero);

            Assert.Equal(resultado, verifica);
        }
    }
}
