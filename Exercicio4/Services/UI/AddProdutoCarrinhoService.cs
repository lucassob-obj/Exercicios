using Exercicio4.Interfaces;
using Exercicio4.Models;
using Exercicio4.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4.Services
{
    public class AddProdutoCarrinhoService : IOpcao
    {
        private IManipulaCarrinhoService _manipulaCarrinhoService { get; set; }
        private List<Produto> Catalogo { get; set; }
        private Models.Carrinho Carrinho { get; set; }

        public AddProdutoCarrinhoService(Models.Carrinho Carrinho, List<Produto> Catalogo)
        {
            this.Carrinho = Carrinho;
            this.Catalogo = Catalogo;
            this._manipulaCarrinhoService = new ManipulaCarrinhoService(Carrinho);
        }
        public void RealizarAcao()
        {
            Console.WriteLine(" Digite o codigo do produto:");
            int codigo = int.Parse(Console.ReadLine());
            var produto = Catalogo.FirstOrDefault(p => p.Codigo == codigo);
            Console.WriteLine("Digite a quantidade:");
            int qtde = int.Parse(Console.ReadLine());
            _manipulaCarrinhoService.AddProduto(produto, qtde);
            Console.WriteLine("Produto adicionado ao carrinho.");
        }
    }
}
