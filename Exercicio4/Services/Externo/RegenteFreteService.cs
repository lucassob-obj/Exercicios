using Exercicio4.Interfaces;

namespace Exercicio4.Services
{
    public class RegenteFreteService : IFrete
    {
        private const decimal Frete = 20.9m;
        public decimal CalcularFrete()
        {
            return Frete;
        }
    }
}
