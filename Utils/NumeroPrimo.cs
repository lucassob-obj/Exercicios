using System;

namespace Utils
{
    public class NumeroPrimo
    {
        public static bool VerificaNumeroPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var raiz = (int)Math.Floor(Math.Sqrt(numero));

            for (int i = 3; i <= raiz; i += 2)
                if (numero % i == 0)
                    return false;

            return true;
        }
    }
}
