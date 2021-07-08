using System;
using Xunit;

namespace Exercicio2.Tests
{
    public class UnitTest1
    {
        [Fact(DisplayName = @"Um número não é feliz quando, em seu processo de cálculo, 
            em algum momento ele entra em loop, ou seja, ele passe por um número que ele já passou anteriormente")]
        public void NumeroNaoFeliz()
        {

        }

        [Fact(DisplayName = @"Um número é feliz quando, a soma recorrente de seus digitos ao quadrado resulta em 1.")]
        public void NumeroFeliz()
        {

        }

        [Fact(DisplayName = @"Deve ser considerado apenas números inteiros positivos.")]
        public void NumeroNaturalValido()
        {
        }
    }
}
