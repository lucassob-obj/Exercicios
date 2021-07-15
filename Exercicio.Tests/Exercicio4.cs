using Exercicio4.Interfaces;
using Exercicio4.Models;
using Exercicio4.Services.Carrinho;
using Moq;
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
        public void RemoverProdutoDoCarrinho()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = new Cliente { CEP = "19570000" };
            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 2,
                Produto = new Produto
                {
                    Codigo = 1,
                    Descricao = "Produto X",
                    Valor = 40.9M
                }
            });
            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho);
            carrinhoService.AlterarQuantidade(carrinho.Itens[0], 0);

            var resultado = carrinhoService.BuscaItemNoCarrinho(1);
            Assert.Null(resultado);
        }

        [Fact]
        public void AdicionarProdutoQueJaExisteNoCarrinho()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = new Cliente { CEP = "19570000" };
            var produto = new Produto
            {
                Codigo = 1,
                Descricao = "Produto X",
                Valor = 40.9M
            };
            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 2,
                Produto = produto
            });


            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho);
            carrinhoService.AddProduto(produto, 3);

            var resultado = carrinhoService.BuscaItemNoCarrinho(1);
            Assert.Equal(1, resultado.Produto.Codigo);
            Assert.Equal("Produto X", resultado.Produto.Descricao);
            Assert.Equal(5, resultado.Quantidade);
        }

        [Fact]
        public void TesteLimparCarrinho()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = new Cliente { CEP = "19570000" };
            var produto1 = new Produto
            {
                Codigo = 1,
                Descricao = "Produto X",
                Valor = 40.9M
            };
            var produto2 = new Produto
            {
                Codigo = 2,
                Descricao = "Produto Y",
                Valor = 50.9M
            };

            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 2,
                Produto = produto1
            });
            carrinho.Itens.Add(new CarrinhoItem
            {
                Quantidade = 1,
                Produto = produto2
            });

            IManipulaCarrinhoService carrinhoService = new ManipulaCarrinhoService(carrinho);
            carrinhoService.LImparCarrinho();

            var resultado1 = carrinhoService.BuscaItemNoCarrinho(1);
            var resultado2 = carrinhoService.BuscaItemNoCarrinho(2);

            Assert.Null(resultado1);
            Assert.Null(resultado2);
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
