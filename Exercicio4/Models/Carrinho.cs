using System.Collections.Generic;

namespace Exercicio4.Models
{
    public class Carrinho
    {
        public Cliente Cliente { get; set; }
        public IEnumerable<CarrinhoItem> Itens { get; set; }
    }

    public class CarrinhoItem
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
