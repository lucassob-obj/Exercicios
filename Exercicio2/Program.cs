using System;
using Utils;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = int.Parse(Console.ReadLine());
            //while (numero != 0)
            //{
            //    if (NumeroFeliz.VerificarNumero(numero))
            //        Console.WriteLine("O número {0} é feliz!", numero);
            //    else
            //        Console.WriteLine("O número {0} não é feliz.", numero);

            //    numero = int.Parse(Console.ReadLine());
            //}

            //Console.ReadKey();

            for(int i = 0; i < 100; i++)
            {
                if (NumeroFeliz.VerificarNumero(i))
                    Console.WriteLine("O número {0} é feliz!", i);
                else
                    Console.WriteLine("O número {0} não é feliz.", i);
            }
        }
    }
}
