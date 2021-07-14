using Exercicio4.Interfaces;
using Exercicio4.Models;
using Exercicio4.Services;
using Moq;
using System.Linq;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio4
    {
        [Fact]
        public void TesteCEPComValorMenorQue100()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = new Cliente { CEP = "19570000" };
            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 2,
                Produto = new Produto
                {
                    Descricao = "Produto X",
                    Valor = 40.9M
                }
            });
            Mock<IFrete> frete = new Mock<IFrete>();
            var valorCarrinho = carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor);

            frete.Setup(f => f.CalcularFrete(valorCarrinho)).Returns(20.9m);

            var resultadoEsperado = frete.Object.CalcularFrete(valorCarrinho);
            var resultado = new RegenteFreteService().CalcularFrete(valorCarrinho);

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
