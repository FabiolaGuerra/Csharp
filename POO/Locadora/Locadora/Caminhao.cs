using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    internal class Caminhao : Veiculos
    {
        public Caminhao(string modelo, string marca, int ano, decimal valorBaseDiarioAlguel) : base(modelo, marca, ano, valorBaseDiarioAlguel)
        {
            
        }
        public override decimal CalcularValorAluguel(int dias)
        {
            return (dias * ValorBaseDiarioAluguel) + ((dias * ValorBaseDiarioAluguel) * 0.2m);
        }
    }
}
