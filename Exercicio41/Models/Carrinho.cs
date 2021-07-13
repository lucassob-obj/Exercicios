using System.Collections.Generic;

namespace Exercicio4.Models
{
    public class Carrinho
    {
        public Carrinho()
        {
            Itens = new List<CarrinhoItem>();
        }
        public Cliente Cliente { get; set; }
        public IEnumerable<CarrinhoItem> Itens { get; set; }
    }

}
