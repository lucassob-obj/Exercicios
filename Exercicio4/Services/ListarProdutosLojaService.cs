using Exercicio4.Interfaces;
using Exercicio4.Models;
using System;
using System.Collections.Generic;

namespace Exercicio4.Services
{
    public class ListarProdutosLojaService : IListarProdutosLoja
    {
        public void RealizarAcao(IEnumerable<Produto> produtos)
        {
            foreach (var produto in produtos)
                Console.WriteLine($" Código: {produto.Codigo} | Descrição: {produto.Descricao} | Valor: {produto.Valor}");
        }
    }
}
