using Exercicio4.Models;
using System.Collections.Generic;

namespace Exercicio4.Interfaces
{
    public interface IListarProdutosLoja
    {
        public void RealizarAcao(IEnumerable<Produto> produtos);
    }
}
