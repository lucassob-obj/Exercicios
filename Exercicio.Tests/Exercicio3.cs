using Utils;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio3
    {
        [Theory(DisplayName = "Teste da soma dos caracteres da palavra")]
        [InlineData("teste", 199)]
        [InlineData("perera", 219)]
        public void SomaPalavra(string palavra, int numero)
        {
            int soma = Palavra.SomaPalavra(palavra);

            Assert.Equal(numero, soma);
        }

        //[Theory(DisplayName = "Teste da soma dos caracteres da palavra")]
        //[InlineData(199, 199)]
        //[InlineData(219, 219)]
        //public void NumeroPrimo(int soma, int numero)
        //{
        //    int soma = Palavra.SomaPalavra(palavra);
        //    bool primo = Utils.NumeroPrimo.VerificaNumeroPrimo(soma);
        //    Assert.Equal(numero, );
        //}
    }
}
