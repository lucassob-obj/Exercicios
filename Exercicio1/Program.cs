using Exercicio1.Interface;
using Exercicio1.Model;
using Exercicio1.Service;
using System;
using Utils;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            INumeroNaturalService service = new NumeroNaturalService();

            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de 3 ou 5 é: { service.SomaMultiplos(new TresOuCinco()) }");
            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de 3 e 5 é: { service.SomaMultiplos(new TresECinco()) }");
            Console.WriteLine($@"A soma dos números naturais menores que 1000 multiplos de (3 ou 5) e 7 é: { service.SomaMultiplos(new TresOuCincoESete()) }");
        }
    }
}
