using Exercicio4.Interfaces;

namespace Exercicio4.Services
{
    public class PirapozinhoFreteService : IFrete
    {
        private const decimal Frete = 30.9m;
        public decimal CalcularFrete()
        {
            return Frete;
        }
    }
}
