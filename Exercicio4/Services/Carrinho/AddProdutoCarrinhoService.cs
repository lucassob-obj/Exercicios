using Exercicio4.Interfaces;
using Exercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4.Services
{
    public class AddProdutoCarrinhoService : IOpcao
    {
        public void RealizarAcao(Models.Carrinho carrinho)
        {
            Console.WriteLine(" Digite o codigo do produto:");
            int codigo = int.Parse(Console.ReadLine());
            var produto = carrinho.Itens.Where(p => p.Produto.Codigo == codigo).Select(s => s.Produto).FirstOrDefault();
            Console.WriteLine("Digite a quantidade:");
            int qtde = int.Parse(Console.ReadLine());
            var item = carrinho.Itens.FirstOrDefault(x => x.Produto.Codigo == codigo);
            if (item != null)
                item.Quantidade++;
            else
                ((List<CarrinhoItem>)carrinho.Itens).Add(new CarrinhoItem
                {
                    Produto = produto,
                    Quantidade = qtde
                });
            Console.WriteLine("Produto adicionado ao carrinho.");
        }
    }
}
