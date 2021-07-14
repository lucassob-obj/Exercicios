using Exercicio4.Enum;
using Exercicio4.Interfaces;
using Exercicio4.Models;
using Exercicio4.Services;
using Exercicio4.Services.Carrinho;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.Cliente = InicializaCliente();
            IEnumerable<Produto> produtos = InicializaProdutos();
            List<IOpcao> opcoes = InicializaOpcoes(int.Parse(carrinho.Cliente.CEP));

            int opcao = 0;
            while ((opcao = Menu()) != 0)
            {
                if (opcao == 1)
                {
                    foreach (Produto produto in produtos)
                        Console.WriteLine($" Descrição: {produto.Descricao} | Preço unitário: {produto.Valor}");
                }
                else
                    opcoes[opcao - 2].RealizarAcao(carrinho);

                Console.WriteLine("\nPrecione qualquer tecla...");
                Console.ReadLine();
            }
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("     --- Menu ---");
            Console.WriteLine(" 1 - Listar produtos");
            Console.WriteLine(" 2 - Adicionar produto no carrinho");
            Console.WriteLine(" 3 - Listar produtos do carrinho");
            Console.WriteLine(" 4 - Calcular frete");
            Console.WriteLine(" 5 - Alterar quantidade do produto");
            Console.WriteLine(" 6 - Limpar o carrinho");
            Console.WriteLine(" 0 - Sair");
            return int.Parse(Console.ReadLine());
        }

        static List<IOpcao> InicializaOpcoes(int CEP)
        {
            IFrete freteService;
            if (CEP == (int)FreteCEP.Regente)
                freteService = new RegenteFreteService();
            else
                freteService = new PirapozinhoFreteService();

            List<IOpcao> opcoes = new List<IOpcao>();
            opcoes.Add(new AddProdutoCarrinhoService());
            opcoes.Add(new ListarProdutosService());
            opcoes.Add(new CalcularFreteCarrinhoService(freteService));
            opcoes.Add(new AlterarQuantidadeCarrinhoService());
            opcoes.Add(new LimparCarrinhoService());
            return opcoes;
        }

        static Cliente InicializaCliente()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine(" Nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine(" CEP: ");
            cliente.CEP = Console.ReadLine();
            return cliente;
        }

        static List<Produto> InicializaProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto
            {
                Codigo = 1,
                Descricao = "Camiseta com estampa X",
                Valor = 49.9M
            });
            produtos.Add(new Produto
            {
                Codigo = 2,
                Descricao = "Boné da marca Y",
                Valor = 20.9M
            });
            produtos.Add(new Produto
            {
                Codigo = 3,
                Descricao = "Tenis da marca Z",
                Valor = 90.9M
            });
            return produtos;
        }
    }
}
