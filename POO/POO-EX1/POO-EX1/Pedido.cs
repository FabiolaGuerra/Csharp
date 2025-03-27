using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX1
{
    public class Pedido
    {
        public int NumeroPedido;
        public List<Produto> itens = new List<Produto>();

        public double CalcularValorTotal()
        {
            double ValorTotal = 0;
            foreach (var item in itens)
            {
                ValorTotal += item.Preco;
            }
            return ValorTotal;

        }

        public void ExbirItem()
        {
            
            foreach (var item in itens)
            {
                Console.WriteLine("Produto: " + item.Nome + " Preço: " + item.Preco);
            }

            Console.WriteLine($"Total da compra: {CalcularValorTotal()}");

        }

        

    }

}
