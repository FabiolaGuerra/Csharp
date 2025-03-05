using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Recursividade
{
    internal class Matematica
    {
       
        public static int Soma(int n)
        {
           if (n == 1) return 1;
            return n + Soma(n - 1);
        }

       
        public static int Fatorial (int n)
        {
            if (n == 0) return 0;
            return n * Fatorial(n - 1);
        }

        public static int Potencia(int n, int expoente)
        {
            if (expoente == 1)
            {
                return n*1;
            }
            return n * Potencia(n, expoente - 1);

        }

        public static void Fibonacci(int termo1, int termo2, int n)
        {
            if (n != 0)
            {
                Console.WriteLine(termo1);
                Fibonacci(termo2, termo1 + termo2, n - 1);
            }
           

        }

        public static void ContagemRegressiva(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
            }else
            {
                Console.WriteLine(n);
                ContagemRegressiva(n-1);
            }
                             
        }
        public static void MDC(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("O MDC é " + a);
            }
            else
            {
                MDC(b, a % b);

            }

    }   }     
}
