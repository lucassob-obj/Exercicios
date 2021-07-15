using Exercicio4.Models;

namespace Exercicio4.Interfaces
{
    public interface IManipulaCarrinhoService
    {
        public void AddProduto(Produto produto, int quantidade);

        public void AlterarQuantidade(CarrinhoItem item, int quantidade);

        public decimal CalcularFreteCarrinho();

        public decimal CalcularValorCarrinho();

        public CarrinhoItem BuscaItemNoCarrinho(int codigo);

        public void LImparCarrinho();
    }
}
