using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Conta_Bancária
{
    public class ContaPoupanca : Conta_Bancaria

    {//possui um bônus de 0.5% sobre cada depósito
        
        private double PercentualBonusDeposito = 0.005;
        public ContaPoupanca(int numeroConta, string nomeTitular, double saldo) : base(numeroConta, nomeTitular, saldo)
        {
            TaxaSaque = 0;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                var valorComBonus = valor + (valor * PercentualBonusDeposito);
                base.Depositar(valorComBonus);
                Console.WriteLine($"Deposito de R$ {valor:F2} foi realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível na conta poupança: R$ {Saldo}");
        }
    }
}
