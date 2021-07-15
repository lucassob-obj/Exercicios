using Exercicio4.Interfaces;
using Exercicio4.Models;
using Exercicio4.Services;
using Exercicio4.Services.Carrinho;
using Moq;
using System.Linq;
using Xunit;

namespace Exercicio.Tests
{
    public class Exercicio4
    {
        [Fact]
        public void ValorFinalDoCarrinhoComProdutos()
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
            Mock<IManipulaCarrinhoService> mockCarrinho = new Mock<IManipulaCarrinhoService>();
            mockCarrinho.Setup(m => m.CalcularValorCarrinho()).Returns(81.8M);
            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho);

            decimal resultadoEsperado = mockCarrinho.Object.CalcularValorCarrinho();
            decimal resultado = carrinhoService.CalcularValorCarrinho();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void ValorFinalDoCarrinhoSemProdutos()
        {
            Carrinho carrinho = new Carrinho();

            Mock<IManipulaCarrinhoService> mockCarrinho = new Mock<IManipulaCarrinhoService>();
            mockCarrinho.Setup(m => m.CalcularValorCarrinho()).Returns(0);
            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService();

            decimal resultadoEsperado = mockCarrinho.Object.CalcularValorCarrinho();
            decimal resultado = carrinhoService.CalcularValorCarrinho();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteCEPRegenteComValorMenorQue100()
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
            frete.Setup(m => m.CalcularFrete()).Returns(20.9M);
            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho, frete.Object);

            decimal resultadoEsperado = frete.Object.CalcularFrete();
            decimal resultado = carrinhoService.CalcularFreteCarrinho();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TesteCEPPirapozinhoComValorMaiorQue100()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = new Cliente { CEP = "19200000" };
            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 3,
                Produto = new Produto
                {
                    Descricao = "Produto X",
                    Valor = 52.9M
                }
            });
            Mock<IFrete> frete = new Mock<IFrete>();
            frete.Setup(m => m.CalcularFrete()).Returns(0);
            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho, frete.Object);

            decimal resultadoEsperado = frete.Object.CalcularFrete();
            decimal resultado = carrinhoService.CalcularFreteCarrinho();

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
