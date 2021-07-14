using Exercicio4.Enum;
using Exercicio4.Interfaces;
using Exercicio4.Models;
using System;
using System.Collections.Generic;
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
            if (valorCarrinho < 100)
            {
                Console.WriteLine($"Valor do frete: R${frete.CalcularFrete()}");
                Console.WriteLine($"Valor final: R$ {valorCarrinho + frete.CalcularFrete()}");
            }
            else
            {
                Console.WriteLine($"Valor do frete: R$ 0,0");
                Console.WriteLine($"Valor final: R$ {valorCarrinho}");
            }
        }
    }
}
