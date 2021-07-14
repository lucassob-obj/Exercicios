using Exercicio4.Interfaces;

namespace Exercicio4.Services.Carrinho
{
    public class RealizaAcaoService : IRealizaAcaoService
    {
        private IOpcao opcao;
        public RealizaAcaoService(IOpcao opcao)
        {
            this.opcao = opcao;
        }

        public void RealizaAcao(Models.Carrinho carrinho)
        {
            opcao.RealizarAcao(carrinho);
        }
    }
}
