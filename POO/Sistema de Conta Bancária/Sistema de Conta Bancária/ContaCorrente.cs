using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Conta_Bancária
{//cobra uma taxa fixa de R$ 5,00 a cada saque
    public class ContaCorrente : Conta_Bancaria
    {
        public ContaCorrente(int numeroConta, string nomeTitular, double saldo) : base(numeroConta, nomeTitular, saldo)
        {
            TaxaSaque = 5;
        }
        
        //public void Depositar(double valor)
        //{
        //    base.Depositar(valor);
        //    Console.WriteLine("Depósito realizado.");
        //}

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível na conta corrente: R$ {Saldo}");
        }

        //public void Sacar(double valor)
        //{
        //    if (valor + 5 <= Saldo)
        //    {
        //        base.Sacar(valor);
        //        Console.WriteLine("Saque realizado.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Saldo insuficiente.");   
        //    }
            


        //}
    }


    
}
   

