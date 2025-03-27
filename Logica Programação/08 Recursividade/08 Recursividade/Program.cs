
using System.Runtime.Intrinsics.X86;

namespace _08_Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex01();
            ex02();
            ex03();
            ex04();
            ex05();

        }

        private static void ex05()
        {
            //Exercício 5: Máximo Divisor Comum(MDC): Crie uma função recursiva chamada MDC que recebe dois números
            //inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.
            try
            {
                int a = AskNumber("Insira o numero (A)");
                int b = AskNumber("Insira o numero (B)");
                Matematica.MDC(a, b);
            }
            catch (FormatException)
            {
                Console.WriteLine("Insira apenas numeros inteiros");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }


        }

        private static void ex04()
        {
            //Exercício 4: Contagem Regressiva:
            //Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como
            //parâmetro e exibe uma contagem regressiva de n até 1.
            try
            {
                int n = AskNumber("Digite um numero para cootagem regressiva");
                Matematica.ContagemRegressiva(n);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Inesperado: {ex.Message}");
            }


        }

        private static void ex03()
        {
            //  Exercício 3: Fibonacci: Desenvolva uma função recursiva chamada Fibonacci que recebe um número
            //  inteiro n como parâmetro e retorna o n - ésimo termo da sequência de Fibonacci.
            try
            {
                int n = 0;
                int resultado = AskNumber("Digite um numero");
                Matematica.Fibonacci(0, 1, resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Inesperado:{ex.Message}");

            }

        }

        private static void ex02()
        {
            //Exercício 2: Soma de Números Inteiros: Crie uma função recursiva chamada Soma que recebe um número inteiro
            //positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.
            try
            {
                int n = AskNumber("Digite um numero");
                int resultado = Matematica.Soma(n);
                Console.WriteLine($"Soma {n} é {Matematica.Soma(n)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Inesperado: {ex.Message}");
            }


        }

        private static void ex01()
        {
            //Exercício 1: Potência: Implemente uma função recursiva chamada Potencia que recebe dois parâmetros base
            //e expoente e calcula a potência de base elevado a expoente.
            try
            {
                int n = AskNumber("Digite um número");
                int expoente = AskNumber("Digite o numero que deseja elevar");
                Console.WriteLine($"A potencia do {n}^{expoente} é {Matematica.Potencia(n, expoente)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro Inesperado:{ex.Message}");
            }


        }

        public static int AskNumber(string pergunta)

        {

            Console.WriteLine(pergunta);

            return int.Parse(Console.ReadLine());

        }




    }
}
