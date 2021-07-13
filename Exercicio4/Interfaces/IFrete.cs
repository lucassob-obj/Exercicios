using Exercicio4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Interfaces
{
    public interface IFrete
    {
        public decimal CalcularFrete(Carrinho carrinho);
    }
}
