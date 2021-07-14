using Exercicio4.Interfaces;
using System;
using System.Linq;

namespace Exercicio4.Services.Carrinho
{
    public class CalcularFreteCarrinhoService : IOpcao
    {
        private IFrete frete;

        public CalcularFreteCarrinhoService(IFrete frete)
        {
            this.frete = frete;
        }
        public void RealizarAcao(Models.Carrinho carrinho)
        {
            var valorCarrinho = carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor);

            Console.WriteLine($"Valor do frete: R${frete.CalcularFrete(valorCarrinho)}");
            Console.WriteLine($"Valor final: R$ {valorCarrinho + frete.CalcularFrete(valorCarrinho)}");
        }

        public decimal ValorFrete(Models.Carrinho carrinho)
        {
            var valorCarrinho = carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor);
            return frete.CalcularFrete(valorCarrinho);
        }

        public decimal ValorTotal(Models.Carrinho carrinho)
        {
            var valorCarrinho = carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor);
            return valorCarrinho + frete.CalcularFrete(valorCarrinho);
        }
    }
}
