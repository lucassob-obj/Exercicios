using Utils;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio3
    {
        [Theory(DisplayName = "Teste da soma dos caracteres da palavra")]
        [InlineData("teste", 199)]
        [InlineData("perera", 219)]
        public void TesteSomaPalavra(string palavra, int numero)
        {
            int soma = Palavra.SomaPalavra(palavra);
            Assert.Equal(numero, soma);
        }

        [Theory(DisplayName = "Teste de verificação da soma dos caracteres da palavra para número primo ou não")]
        [InlineData(199, true)]
        [InlineData(219, false)]
        public void TesteNumeroPrimo(int soma, bool resultado)
        {
            bool primo = NumeroPrimo.VerificaNumeroPrimo(soma);
            Assert.Equal(resultado, primo);
        }

        [Theory(DisplayName = "Teste de verificação da soma dos caracteres da palavra para número feliz ou não")]
        [InlineData(199, false)]
        [InlineData(219, true)]
        public void TesteNumeroFeliz(int soma, bool resultado)
        {
            bool feliz = NumeroFeliz.VerificarNumero(soma);
            Assert.Equal(resultado, feliz);
        }

        [Theory(DisplayName = "Teste de verificação da soma dos caracteres da palavra para número feliz ou não")]
        [InlineData(199, true)]
        [InlineData(219, false)]
        public void NumeroMultiploDe3Ou5(int soma, bool resultado)
        {
            bool primo = NumeroPrimo.VerificaNumeroPrimo(soma);
            Assert.Equal(resultado, primo);
        }
    }
}
