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
            try
            {
                Carrinho carrinho = new Carrinho();
                carrinho.Cliente = InicializaCliente();
                List<Produto> produtos = InicializaProdutos();
                List<IOpcao> opcoes = InicializaOpcoes(int.Parse(carrinho.Cliente.CEP), produtos);

                int opcao = 0;
                while ((opcao = Menu()) != 0)
                {
                    if (opcao < 0 || opcao > 6)
                        Console.WriteLine("Opção inválida.");
                    else
                        opcoes[opcao - 1].RealizarAcao(carrinho);

                    Console.WriteLine("\nPrecione qualquer tecla...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("     --- Menu ---");
            Console.WriteLine(" 1 - Listar produtos da loja");
            Console.WriteLine(" 2 - Listar produtos do carrinho");
            Console.WriteLine(" 3 - Adicionar produto no carrinho");
            Console.WriteLine(" 4 - Alterar quantidade do produto");
            Console.WriteLine(" 5 - Limpar o carrinho");
            Console.WriteLine(" 6 - Calcular frete");
            Console.WriteLine(" 0 - Sair");
            return int.Parse(Console.ReadLine());
        }

        static List<IOpcao> InicializaOpcoes(int CEP, List<Produto> catalogo)
        {
            IFrete freteService;
            if (CEP == (int)FreteCEP.Regente)
                freteService = new RegenteFreteService();
            else
                freteService = new PirapozinhoFreteService();

            List<IOpcao> opcoes = new List<IOpcao>();
            opcoes.Add(new ListarProdutosService(catalogo));
            opcoes.Add(new ListarProdutosService());
            opcoes.Add(new AddProdutoCarrinhoService(catalogo));
            opcoes.Add(new AlterarQuantidadeCarrinhoService());
            opcoes.Add(new LimparCarrinhoService());
            opcoes.Add(new CalcularFreteCarrinhoService(freteService));
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
