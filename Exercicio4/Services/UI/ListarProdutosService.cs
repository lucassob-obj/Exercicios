using Exercicio4.Interfaces;
using Exercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4.Services
{
    public class ListarProdutosService : IOpcao
    {
        private List<Produto> Catalogo { get; set; }
        private Models.Carrinho Carrinho { get; set; }

        public ListarProdutosService(Models.Carrinho Carrinho)
        {
            this.Carrinho = Carrinho;
        }
        public ListarProdutosService(List<Produto> Catalogo)
        {
            this.Catalogo = Catalogo;
        }

        public void RealizarAcao()
        {
            if (Catalogo != null)
            {
                foreach (Produto produto in Catalogo)
                    Console.WriteLine($" Descrição: {produto.Descricao} | Preço unitário: {produto.Valor}");
            }
            else
            {
                if (Carrinho.Itens.Count() < 1)
                    Console.WriteLine("Não há produtos no carrinho.");
                else
                {
                    foreach (var item in Carrinho.Itens)
                        Console.WriteLine($" Produto: {item.Produto.Descricao} | Quantidade: {item.Quantidade} | Subtotal: {item.Produto.Valor * item.Quantidade}");

                    Console.WriteLine($"\n Total: {Carrinho.Itens.Sum(i => i.Produto.Valor * i.Quantidade)}");
                }
            }
        }
    }
}
