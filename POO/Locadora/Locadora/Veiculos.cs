using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    public class Veiculos : Iveiculos
    {
        public  string Modelo {  get; set; }
        public string Marca {  get; set; }
        public int Ano {  get; set; }
        public decimal ValorBaseDiarioAluguel {  get; set; }

        public Veiculos(string modelo, string marca, int ano, decimal valorBaseDiarioAlguel)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBaseDiarioAluguel = valorBaseDiarioAlguel;
        }
       

        public virtual decimal CalcularValorAluguel(int dias)
        {
            return dias * ValorBaseDiarioAluguel;
        }
        public override string ToString()
        {
            return $"{Marca} - {Modelo} {Ano} - R${ValorBaseDiarioAluguel}";
        }
    }
}
