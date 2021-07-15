using Exercicio4.Interfaces;
using System;
using System.Linq;

namespace Exercicio4.Services.Carrinho
{
    public class CalcularFreteCarrinhoService : IOpcao
    {
        private IManipulaCarrinhoService _carrinhoService;

        public CalcularFreteCarrinhoService(Models.Carrinho Carrinho, IFrete _freteService)
        {
            this._carrinhoService = new ManipulaCarrinhoService(Carrinho, _freteService);
        }
        public void RealizarAcao()
        {
            Console.WriteLine($"Valor do frete: R${_carrinhoService.CalcularFreteCarrinho()}");
            Console.WriteLine($"Valor final: R$ {_carrinhoService.CalcularValorCarrinho() + _carrinhoService.CalcularFreteCarrinho()}");
        }
    }
}
