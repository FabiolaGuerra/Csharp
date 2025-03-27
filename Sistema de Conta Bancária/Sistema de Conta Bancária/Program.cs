namespace Sistema_de_Conta_Bancária
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            ContaCorrente cc = new ContaCorrente(123, "João", 1000);
            ContaPoupanca cp = new ContaPoupanca(456, "João", 500);

            while (true)
            {
                
                Console.WriteLine("\nEscolha uma opçao:\n1 Conta Corrente\n2 Conta Poupança\n3 Para sair");
                string opcaoConta = Console.ReadLine();
                TipoDeConta tipoConta;
                switch (opcaoConta) {
                    case "1":
                        tipoConta = TipoDeConta.ContaCorrente;
                        break;
                    case "2":
                        tipoConta = TipoDeConta.ContaPoupanca;
                        break;
                    default:
                        tipoConta = TipoDeConta.Sair;
                        break;
                }

                if(tipoConta == TipoDeConta.Sair)
                {
                    break;
                }

                Console.WriteLine("\n Escolha operaçao\n 1 Sacar\n2 Depositar\n3 Saldo");
                var operacao = Console.ReadLine();
                TipoOperacao tipoOperacao;
                switch (operacao)
                {
                    case "1":
                        tipoOperacao = TipoOperacao.Saque;
                        break;
                    case "2":
                        tipoOperacao = TipoOperacao.Deposito;
                        break;
                    default:
                        tipoOperacao = TipoOperacao.Saldo;
                        break;
                }

                if(tipoOperacao == TipoOperacao.Saldo)
                {
                    if(tipoConta == TipoDeConta.ContaCorrente)
                    {
                        cc.ExibirSaldo();
                    }
                    else
                    {
                        cp.ExibirSaldo();
                    }
                }

                if(tipoOperacao == TipoOperacao.Saque)
                {
                    Console.WriteLine("Digite o valor do saque");
                    var valor = double.Parse(Console.ReadLine());
                    if (tipoConta == TipoDeConta.ContaCorrente)
                    {
                        cc.Sacar(valor);
                    }
                    else
                    {
                        cp.Sacar(valor);
                    }
                }

                if (tipoOperacao == TipoOperacao.Deposito)
                {
                    Console.WriteLine("Digite o valor do deposito");
                    var valor = double.Parse(Console.ReadLine());
                    if (tipoConta == TipoDeConta.ContaCorrente)
                    {
                        cc.Depositar(valor);
                    }
                    else
                    {
                        cp.Depositar(valor);
                    }
                }
            }


        }
    }
}
