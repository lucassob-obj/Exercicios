using System;
using Utils;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de 3 ou 5 é: {Multiplos.SomaMultiplos(false, true, false)}");
            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de 3 e 5 é: {Multiplos.SomaMultiplos(false, true, true)}");
            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de (3 ou 5) e 7 é: {Multiplos.SomaMultiplos(true, false, true)}");
        }
    }
}
