using Exercicio4.Interfaces;

namespace Exercicio4.Services
{
    public class PirapozinhoFreteService : IFrete
    {
        private const decimal Frete = 30.9m;
        public decimal CalcularFrete(decimal valorCarrinho)
        {
            if (valorCarrinho < 100)
                return Frete;

            return 0;
        }
    }
}
