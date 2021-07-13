﻿using Exercicio4.Interfaces;
using Exercicio4.Models;
using System.Linq;

namespace Exercicio4.Services
{
    public class RegenteFreteService : IFrete
    {
        private const decimal Frete = 20.9m;
        public decimal CalcularFrete(Models.Carrinho carrinho)
        {
            if (carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor) < 100)
                return Frete;

            return 0;
        }
    }
}
