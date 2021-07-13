using Exercicio4.Interfaces;
using System;
using System.Linq;

namespace Exercicio4.Services
{
    public class ListarProdutosCarrinhoService : IOpcao
    {
        public void RealizarAcao(Models.Carrinho carrinho)
        {
            foreach (var item in carrinho.Itens)
                Console.WriteLine($" Produto: {item.Produto.Descricao} | Quantidade: {item.Quantidade} | Subtotal: {item.Produto.Valor * item.Quantidade}");
            Console.WriteLine($"\n Total: {carrinho.Itens.Sum(i => i.Produto.Valor * i.Quantidade)}");
        }
    }
}
