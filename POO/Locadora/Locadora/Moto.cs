using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    internal class Moto : Veiculos
    {
        public Moto(string modelo, string marca, int ano, decimal valorBaseDiarioAlguel) : base(modelo, marca, ano, valorBaseDiarioAlguel)
        {
        }
        public override decimal CalcularValorAluguel(int dias)
        {

            return (dias * ValorBaseDiariaAluguel) - ((dias * ValorBaseDiariaAluguel) * 0.1m);
        }
    }
}
