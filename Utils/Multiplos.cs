namespace Utils
{
    public static class Multiplos
    {
        public static int SomaMultiplos(bool numero7, bool numero3, bool numero5)
        {
            int soma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (numero7)
                {
                    if ((i % 3 == 0 || i % 5 == 0) && i % 7 == 0)
                        soma += i;
                }
                else if (numero3 && numero5)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        soma += i;
                }
                else if (numero3 || numero5)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        soma += i;
                }
            }
            return soma;
        }

        public static bool MultiploDe3Ou5(int numero)
        {
            return numero % 3 == 0 || numero % 5 == 0;
        }
    }
}
