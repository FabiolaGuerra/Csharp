using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Conta_Bancária
{
    public class Conta_Bancaria
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldo;
        private double _taxaSaque = 0;

        public int NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }
       
        protected double TaxaSaque
        {
            get { return _taxaSaque; }
            set { _taxaSaque = value; }
        }

        public Conta_Bancaria(int numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }
       

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito de R$ {valor:F2} foi realizado com sucesso!");
              
            }
            else
            {
                Console.WriteLine("Valor de deposito invalido, favor tentar novamente");
                
            }

        }

        public double Sacar(double valor)
        {
            if (valor > 0 && Saldo>= valor)
            {
                Saldo -= valor + TaxaSaque;
                Console.WriteLine($"Saque de R$ {valor:F2} foi realizado com sucesso!");

                
            }
            else
            {
                Console.WriteLine("Saque não permitido. Saldo insuficiente ou valor inválido.");
            }
            return Saldo;
        }

        public void  ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {Saldo}");
        }
    }
   
}

