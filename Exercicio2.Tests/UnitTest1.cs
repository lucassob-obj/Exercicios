using System;
using Xunit;

namespace Exercicio2.Tests
{
    public class UnitTest1
    {
        [Fact(DisplayName = @"Um n�mero n�o � feliz quando, em seu processo de c�lculo, 
            em algum momento ele entra em loop, ou seja, ele passe por um n�mero que ele j� passou anteriormente")]
        public void NumeroNaoFeliz()
        {

        }

        [Fact(DisplayName = @"Um n�mero � feliz quando, a soma recorrente de seus digitos ao quadrado resulta em 1.")]
        public void NumeroFeliz()
        {

        }

        [Fact(DisplayName = @"Deve ser considerado apenas n�meros inteiros positivos.")]
        public void NumeroNaturalValido()
        {
        }
    }
}
