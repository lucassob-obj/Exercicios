using Exercicio4.Interfaces;
using Exercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4.Services.Carrinho
{
    public class AlterarQuantidadeCarrinhoService : IOpcao
    {
        public void RealizarAcao(Models.Carrinho carrinho)
        {
            Console.WriteLine("Digite o codigo do produto:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que deseja (0 para remover o produto):");
            int quantidade = int.Parse(Console.ReadLine());
            var item = carrinho.Itens.FirstOrDefault(x => x.Produto.Codigo == codigo);
            if (item == null)
                Console.WriteLine("Produto não encontrado no carrinho");
            else
            {
                if (quantidade > 0)
                    item.Quantidade = quantidade;
                else
                    ((List<CarrinhoItem>)carrinho.Itens).Remove(item);
            }
        }
    }
}
