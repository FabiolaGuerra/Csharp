using System.Reflection.Metadata.Ecma335;

namespace POO_EX1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();
            int op = 1;
            while (op != 0)
            {
               operacoes.MostrarOperacoes();
                Console.WriteLine("\nQual operação você deseja realizar?");

                op = int.Parse(Console.ReadLine());
                operacoes.ProcessamentoOperacao(op);

            }        
                

       
        }
      
               

    }
}
