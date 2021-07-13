using Exercicio4.Models;
using System.Linq;

namespace Exercicio4.Services
{
    public class CalculaFreteService
    {
        public decimal CalculaFrete(Carrinho carrinho)
        {
            if (carrinho.Itens.ToList().Sum(x => x.Quantidade * x.Produto.Valor) < 100)
                return TabelaFrete(carrinho.Cliente.CEP);

            return 0;
        }

        public decimal TabelaFrete(string CEP)
        {
            switch (CEP)
            {
                case "19570-000":
                    return 20.9M;
                case "19010-040":
                    return 30.9M;
                case "19010-042":
                    return 40.9M;
            }
            return 0;
        }
    }
}
