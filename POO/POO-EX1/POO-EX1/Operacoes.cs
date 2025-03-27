using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_EX1
{
    internal class Operacoes

    {
        public List<Pedido> pedidos = new List<Pedido>();
        public List<Produto> produtos = new List<Produto>();


        public void MostrarOperacoes()
        {
            Console.WriteLine("1 - Adicionar pedido ");
            Console.WriteLine("2 - Adicionar produto ");
            Console.WriteLine("3 - Listar pedidos ");
            Console.WriteLine("4 - Listar produtos ");
            Console.WriteLine("0 - Sair ");
        }
        public void ProcessamentoOperacao(int op)
        {
            switch (op)
            {
                case 1:
                    AdicionarPedido();
                    break;
                case 2:
                    AdicionarProduto();
                    break;
                case 3:
                    ListarPedidos();
                    Retorno();
                    break;
                case 4:
                    ListarProdutos();
                    Retorno();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

        }
        public void AdicionarPedido()
        {
            Pedido pedido = new Pedido();
            pedido.NumeroPedido = GerarNumeroPedido(pedidos);
            pedidos.Add(pedido);
            Console.WriteLine("\rProdutos disponiveis");
            ListarProdutos();
            while (true)
            {
                Console.WriteLine("Qual item deseja pedir? (Digite 0 para sair)");
                int numeroItem = int.Parse(Console.ReadLine());
                if (numeroItem == 0)
                {
                    break;
                }
                pedido.itens.Add(produtos[numeroItem - 1]);

            }
            Console.Clear();

        }

        public void AdicionarProduto()
        {

            while (true)
            {
                Produto produto = new Produto();
                Console.WriteLine("Digite o nome do produto");
                produto.Nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto");
                produto.Preco = double.Parse(Console.ReadLine());
                produtos.Add(produto);
                Console.WriteLine("Quer adicionar outro produto? (Digite 0 para sair) ");
                string op = Console.ReadLine();
                if (op == "0")
                {
                    break;
                }

            }
            Console.Clear();
        }

        public void ListarPedidos()
        {
            foreach (Pedido p in pedidos)
            {
                Console.WriteLine($"Pedido #{p.NumeroPedido}");
                p.ExbirItem();
            }
        }


        public void ListarProdutos()
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine($"{i + 1} {produtos[i].Nome} Preço: {produtos[i].Preco}");
            }
            
        }


        public static int GerarNumeroPedido(List<Pedido> pedidos)
        {
            int numeroPedido = 0;
            foreach (Pedido item in pedidos)
            {
                if (numeroPedido <= item.NumeroPedido)
                {
                    numeroPedido = item.NumeroPedido;
                }

            }
            return numeroPedido + 1;
        }

        static void Retorno()
        {
            int r = 1;
            while (r != 0)
            {
                Console.WriteLine("Digite 0 para sair");
                r = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }
       
    }

}
