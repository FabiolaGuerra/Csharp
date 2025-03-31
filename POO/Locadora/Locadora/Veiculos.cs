using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora
{
    public class Veiculos : Iveiculos
    {
        private string _modelo;
        private string _marca;
        private int _ano;
        private decimal _valorBaseDiarioAluguel;

        public Veiculos(string modelo, string marca, int ano, decimal valorBaseDiarioAlguel)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _valorBaseDiarioAluguel = valorBaseDiarioAlguel;
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public decimal ValorBaseDiariaAluguel
        {
            get { return _valorBaseDiarioAluguel; }
            set { _valorBaseDiarioAluguel = value; }
        }

        public virtual decimal CalcularValorAluguel(int dias)
        {
            return dias * _valorBaseDiarioAluguel;
        }
        public override string ToString()
        {
            return $"{Marca} - {Modelo} {Ano} - R${ValorBaseDiariaAluguel}";
        }
    }
}
