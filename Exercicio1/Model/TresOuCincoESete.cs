using Exercicio1.Interface;

namespace Exercicio1.Model
{
    public class TresOuCincoESete : INumeroNatural
    {
        public int Multiplo(int numero)
        {
            return (numero % 3 == 0 || numero % 5 == 0) && numero % 7 == 0 ? numero : 0;
        }
    }
}
