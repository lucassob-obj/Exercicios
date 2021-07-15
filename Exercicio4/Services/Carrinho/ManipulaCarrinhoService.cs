using Exercicio4.Interfaces;
using Exercicio4.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4.Services.Carrinho
{
    public class ManipulaCarrinhoService : IManipulaCarrinhoService
    {
        private Models.Carrinho Carrinho { get; set; }
        private IFrete _freteService { get; set; }
        public ManipulaCarrinhoService() { }
        public ManipulaCarrinhoService(Models.Carrinho Carrinho)
        {
            this.Carrinho = Carrinho;
        }
        public ManipulaCarrinhoService(Models.Carrinho Carrinho, IFrete _freteService)
        {
            this.Carrinho = Carrinho;
            this._freteService = _freteService;
        }
        public void AddProduto(Produto produto, int quantidade)
        {
            var item = Carrinho.Itens.FirstOrDefault(i => i.Produto.Codigo == produto.Codigo);
            if (item != null)
                item.Quantidade++;
            else
                Carrinho.Itens.Add(new CarrinhoItem
                {
                    Quantidade = quantidade,
                    Produto = produto
                });
        }

        public void AlterarQuantidade(CarrinhoItem item, int quantidade)
        {
            if (quantidade > 0)
                item.Quantidade = quantidade;
            else
                Carrinho.Itens.Remove(item);
        }

        public decimal CalcularFreteCarrinho()
        {
            var valorCarrinho = CalcularValorCarrinho();

            if (valorCarrinho < 100)
                return _freteService.CalcularFrete();

            return 0;
        }

        public decimal CalcularValorCarrinho()
        {
            if (Carrinho != null && Carrinho.Itens.Count > 0)
                return Carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor);

            return 0;
        }

        public CarrinhoItem BuscaItemNoCarrinho(int codigo)
        {
            return Carrinho.Itens.FirstOrDefault(c => c.Produto.Codigo == codigo);
        }

        public void LImparCarrinho()
        {
            Carrinho.Itens = new List<CarrinhoItem>();
        }
    }
}
