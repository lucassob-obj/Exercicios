using Exercicio4.Interfaces;

namespace Exercicio4.Services.Carrinho
{
    public class LimparCarrinhoService : IOpcao
    {
        public IManipulaCarrinhoService CarrinhoService { get; set; }
        public LimparCarrinhoService(Models.Carrinho Carrinho)
        {
            CarrinhoService = new ManipulaCarrinhoService(Carrinho);
        }
        public void RealizarAcao()
        {
            CarrinhoService.LImparCarrinho();
        }
    }
}
