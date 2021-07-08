using System;
using Utils;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();
            while (!Palavra.VerificaPalavraValida(palavra))
                Console.WriteLine("Palavra inválida");

            int soma = Palavra.SomaPalavra(palavra);
            Console.WriteLine("A soma dos caracteres da palavra é: {0}", soma);
            Console.WriteLine("A soma dos caracteres da palavra {0}", NumeroPrimo.VerificaNumeroPrimo(soma) ? " é um número primo." : "não é um número primo.");
            Console.WriteLine("A soma dos caracteres da palavra {0}", NumeroFeliz.VerificarNumero(soma) ? " é um número feliz." : "não é um número feliz.");
            Console.WriteLine("A soma dos caracteres da palavra {0}", Multiplos.MultiploDe3Ou5(soma) ? "é multiplo de 3 ou 5." : "não é multiplo de 3 ou 5.");
        }
    }
}
