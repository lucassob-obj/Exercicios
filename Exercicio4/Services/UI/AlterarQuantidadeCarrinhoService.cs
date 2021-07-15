using Exercicio4.Interfaces;
using System;
using System.Linq;

namespace Exercicio4.Services.Carrinho
{
    public class AlterarQuantidadeCarrinhoService : IOpcao
    {
        private Models.Carrinho Carrinho { get; set; }
        private IManipulaCarrinhoService _manipulaCarrinhoService { get; set; }
        public AlterarQuantidadeCarrinhoService(Models.Carrinho Carrinho)
        {
            this.Carrinho = Carrinho;
            this._manipulaCarrinhoService = new ManipulaCarrinhoService(Carrinho);
        }
        public void RealizarAcao()
        {
            Console.WriteLine("Digite o codigo do produto:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que deseja (0 para remover o produto):");
            int quantidade = int.Parse(Console.ReadLine());
            var item = Carrinho.Itens.FirstOrDefault(x => x.Produto.Codigo == codigo);
            if (item == null)
                Console.WriteLine("Produto não encontrado no carrinho");
            else
                _manipulaCarrinhoService.AlterarQuantidade(item, quantidade);
        }
    }
}
