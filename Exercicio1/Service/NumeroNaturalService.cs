using Exercicio1.Interface;

namespace Exercicio1.Service
{
    public class NumeroNaturalService : INumeroNaturalService
    {
        public int SomaMultiplos(INumeroNatural numeroNatural)
        {
            int soma = 0;

            for (int i = 1; i < 1000; i++)
            {
                soma += numeroNatural.Multiplo(i);
            }

            return soma;
        }
    }
}
