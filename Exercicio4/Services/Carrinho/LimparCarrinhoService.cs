using Exercicio4.Interfaces;
using Exercicio4.Models;
using System.Collections.Generic;

namespace Exercicio4.Services.Carrinho
{
    public class LimparCarrinhoService : IOpcao
    {
        public void RealizarAcao(Models.Carrinho carrinho)
        {
            carrinho.Itens = new List<CarrinhoItem>();
        }
    }
}
