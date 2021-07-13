using Exercicio4.Models;
using System.Collections.Generic;
using System;

namespace Exercicio4
{
    static class Program
    {

        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Carrinho carrinho = new Carrinho();
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto
            {
                Codigo = 1,
                Descricao = "Camiseta com estampa X",
                Valor = 49.9M
            });
            produtos.Add(new Produto
            {
                Codigo = 1,
                Descricao = "Boné da marca Y",
                Valor = 20.9M
            });
            produtos.Add(new Produto
            {
                Codigo = 1,
                Descricao = "Tenis da marca Z",
                Valor = 90.9M
            });
            Menu();

        }

        static void Menu()
        {
            Console.WriteLine("     --- Menu ---");
            Console.WriteLine(" 1 - Listar produtos");
            Console.WriteLine(" 2 - Adicionar produto no carrinho");
            Console.WriteLine(" 3 - Calcular frete");
            Console.WriteLine(" 0 - Sair");
        }
    }
}
