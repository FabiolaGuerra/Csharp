using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes_07
{
    internal class funcoes
    {
        public static void ImprimaMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++) 
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha,coluna]+" ");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int SomarMatriz(int[,] matriz)
        {
            int total = 0;
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    total += matriz[linha, coluna];
                }
            }
            return total;
        }

        public static (int,int) EncontreMaiorMenor(int[,] matriz)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (maior < matriz[linha, coluna])
                    {
                        maior=matriz[linha, coluna];
                    }

                    if (menor>matriz[linha, coluna])
                    {
                        menor=matriz[linha, coluna];
                    }
                }
            }
            return (menor, maior);
      
        }
        public static void ImprimaDiagonal(int[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if(linha == coluna)
                    {
                        Console.Write(matriz[linha, coluna] + " ");
                    }
                    else
                    {
                        Console.Write("x" + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
                        
        }
        public static bool EhIdentidade(int[,] matriz)
        {
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (linha == coluna)
                    {
                        if (matriz[linha,coluna] != 1)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (matriz[linha, coluna] != 0)
                        {
                            return false;
                        }
                        
                    }
                }
            }

            return true;
        }

        public static double CalcularMedia(int[,] matriz)
        {
            int soma = SomarMatriz(matriz);
            int qdtDeLinhas = matriz.GetLength(0);
            int qtdDeColunas = matriz.GetLength(1);
            int qtdDeElementos = qdtDeLinhas * qtdDeColunas;
            return (double)soma /(double) qtdDeElementos;
        }
       public static void TransponhaMatriz(int[,] matriz)
       {
            int[,] matrizNova = new int[matriz.GetLength(0), matriz.GetLength(1)];

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matrizNova[linha, coluna]= matriz[coluna, linha];
                }
            }

            ImprimaMatriz(matrizNova);
        }

        internal static void CalculaNulos(int?[,] matriz)
        {
            int qtdValoresNulos = 0;
            int qtdValoresNaoNulos = 0;
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if(matriz[linha, coluna].HasValue)
                    {
                        qtdValoresNaoNulos++;
                    }
                    else {  
                        qtdValoresNulos++;
                    }
                }
            }
            Console.WriteLine($"Nulos ={qtdValoresNulos}, não nulos = {qtdValoresNaoNulos}");
            if (qtdValoresNulos > qtdValoresNaoNulos)
            {
                Console.WriteLine("Tem mais nulos do que não nulos");
            }
            else
            {
                Console.WriteLine("Tem menos nulos do que não nulos");
            }

        }
    }
}
