using Exercicio4.Models;
using Exercicio4.Services;
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
            CalculaFreteService freteService = new CalculaFreteService();
            
            int opcao = 0;
            while ((opcao = Menu()) != 0)
            {
                if (opcao == 1)
                {
                    foreach (var produto in produtos)
                        Console.WriteLine($" Código: {produto.Codigo} | Descrição: {produto.Descricao} | Valor: {produto.Valor}");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine(" Digite o codigo do produto:");
                    int codigo = int.Parse(Console.ReadLine());
                    var produto = produtos.FirstOrDefault(p => p.Codigo == codigo);
                    Console.WriteLine("Digite a quantidade:");
                    int qtde = int.Parse(Console.ReadLine());
                    var item = carrinho.Itens.FirstOrDefault(x => x.Produto.Codigo == codigo);
                    if (item != null)
                        item.Quantidade++;
                    else
                        ((List<CarrinhoItem>)carrinho.Itens).Add(new CarrinhoItem
                        {
                            Produto = produto,
                            Quantidade = qtde
                        });
                    Console.WriteLine("Produto adicionado ao carrinho.");
                }
                else if (opcao == 3)
                {
                    foreach (var item in carrinho.Itens)
                        Console.WriteLine($" Produto: {item.Produto.Descricao} | Quantidade: {item.Quantidade} | Subtotal: {item.Produto.Valor * item.Quantidade}");
                    Console.WriteLine($"\n Total: {carrinho.Itens.Sum(i => i.Produto.Valor * i.Quantidade)}");
                }
                else if (opcao == 4)
                {
                    decimal frete = freteService.CalculaFrete(carrinho);
                    decimal valorFinal = frete + carrinho.Itens.Sum(i => i.Quantidade * i.Produto.Valor);
                    Console.WriteLine($"O valor do frete é: {frete}");
                    Console.WriteLine($"Valor final: {valorFinal}");
                }
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
            Console.WriteLine(" 0 - Sair");
            return int.Parse(Console.ReadLine());
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

        static IEnumerable<Produto> InicializaProdutos()
        {
            IEnumerable<Produto> produtos = new List<Produto>();
            ((List<Produto>)produtos).Add(new Produto
            {
                Codigo = 1,
                Descricao = "Camiseta com estampa X",
                Valor = 49.9M
            });
            ((List<Produto>)produtos).Add(new Produto
            {
                Codigo = 2,
                Descricao = "Boné da marca Y",
                Valor = 20.9M
            });
            ((List<Produto>)produtos).Add(new Produto
            {
                Codigo = 3,
                Descricao = "Tenis da marca Z",
                Valor = 90.9M
            });
            return produtos;
        }
    }
}
