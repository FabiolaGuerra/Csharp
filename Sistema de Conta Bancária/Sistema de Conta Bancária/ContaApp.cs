using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Conta_Bancária
{
    public class ContaApp
    {
        public ContaApp() { }

        public ContaCorrente Corrente { get; set; }
        public ContaPoupanca Poupanca{ get; set; }

        internal void DebitarCorrente(int valor)
        {
            Poupanca.Sacar(valor);
        }
    }
}
