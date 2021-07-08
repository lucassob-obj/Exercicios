using System.Linq;

namespace Utils
{
    public static class Palavra
    {
        public static int SomaPalavra(string palavra)
        {
            int resultado = 0;
            for (int i = 0; i < palavra.Length; i++)
                if (char.IsUpper(palavra[i]))
                    resultado += ((byte)palavra[i]) - 64;
                else
                    resultado += ((byte)palavra[i]) - 70;

            return resultado;
        }

        public static bool VerificaPalavraValida(string palavra)
        {
            return palavra.Any(p => !char.IsLetter(p));
        }
    }
}
