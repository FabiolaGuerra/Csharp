namespace POO_EX1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto Hamburgue = new Produto();
            Hamburgue.Nome = "Hamburgue";
            Hamburgue.Preco = 34.5;
            Produto Batata = new Produto();
            Batata.Nome = "Batata-frita";
            Batata.Preco = 13.5;
            Produto Refrigerante = new Produto();
            Refrigerante.Nome = "Refrigerante";
            Refrigerante.Preco = 5.0;
            Produto Agua = new Produto();
            Agua.Nome = "Agua";
            Agua.Preco = 3.0;
            Produto Sorvete = new Produto();
            Sorvete.Nome = "Sorvete";
            Sorvete.Preco = 7.0;
            Produto Cerveja = new Produto();
            Cerveja.Nome = "Cerveja";
            Cerveja.Preco = 10.0;



            Pedido pedido = new Pedido();
            pedido.NumeroPedido = 1;
            pedido.itens.Add(Hamburgue);            
            pedido.itens.Add(Batata);
            pedido.itens.Add(Refrigerante);
            pedido.itens.Add(Agua);
            pedido.Print();
           



        }
    }
}
