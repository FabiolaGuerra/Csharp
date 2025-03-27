using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    public class Pessoa
    {
        private string nome;
      public int idade;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected string CPF { get; set; }
        public Pessoa()
        {
            this.nome = "sem nome";
            this.idade = 0;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nome {nome}");
            Console.WriteLine($"CPF {CPF}");
            Console.WriteLine($"Idade {idade}");

        }
    }
    
}