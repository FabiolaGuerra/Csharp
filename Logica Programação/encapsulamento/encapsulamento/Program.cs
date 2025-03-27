namespace encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Roger";
            pessoa.idade = 30;
            //pessoa.CPF = 123456789; // Error: 'Pessoa.CPF' is inaccessible due to its protection level
            pessoa.Imprimir();
        }
    }
}
