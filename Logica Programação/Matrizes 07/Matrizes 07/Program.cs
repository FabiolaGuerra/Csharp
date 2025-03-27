
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Matrizes_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ex11();
            ex01();
            ex02();
            ex03();
            ex04();
            ex05();
            ex06();
            ex07();
            ex08();
            ex09();
            ex10();
            
        }

        private static void ex11()
        {
            Console.WriteLine("Digite a quantidades de alunos");
            int qtdalunos = int.Parse(Console.ReadLine());
            List<string> nomesAlunos = new List<string>();
            for (int i = 0; i < qtdalunos; i++)
            {
                Console.WriteLine("Infome o nome do aluno");
                nomesAlunos.Add(Console.ReadLine());
            }
            
            Console.WriteLine("Digite a quantidades de provas do semestre");
            int provas = int.Parse(Console.ReadLine());
            
            int[,] matriz = new int[qtdalunos,provas];

            for (int linha = 0; linha < qtdalunos; linha++)
            {
                Console.WriteLine($"Digite as notas do aluno {nomesAlunos[linha]}");
                for (int coluna = 0; coluna < provas; coluna++)
                {
                    int nota = int.Parse(Console.ReadLine());
                   
                    matriz[linha, coluna] = nota;
                }
            }

            funcoes.ImprimaMatriz(matriz);
        }
        private static void ex10()
        {
            //10.Matriz Dinâmica
            //Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela.
            try
            {
                Console.WriteLine("Digite a quantidades de linhas");
                int linhas = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidades de colunas");
                int colunas = int.Parse(Console.ReadLine());
                int[,] matriz = new int[linhas, colunas];
                for (int linha = 0; linha < linhas; linha++)
                {
                    for (int coluna = 0; coluna < colunas; coluna++)
                    {

                        matriz[linha, coluna] = int.Parse(Console.ReadLine());
                    }
                }

                funcoes.ImprimaMatriz(matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");
                
            }
        }

        private static void ex09()
        {
            //9. Matriz Esparsa Desenvolva um programa que verifica se uma matriz possui mais elementos
            //nulos(0) do que não nulos.
            try
            {
                int?[,] x = new int?[4, 4]
            {
                {1, 2, 3, null },
                {5, 6, 7, 8 },
                {9, 10, 11, 12},
                {null, 14, 15, null}

            };
                funcoes.CalculaNulos(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex08()
        {
            //8.Média dos Elementos Calcule a média dos valores armazenados em uma matriz 4x4.
            //soma tds e divide pela qtd de elementos 
            try
            {
                int[,] x = new int[4, 4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12},
                {13, 14, 15, 16}

            };
                double resultado = funcoes.CalcularMedia(x);
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex07()
        {
            //7. Multiplicação de Matrizes Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado.
            try
            {
                int[,] a = new int[2, 2]
           {
                {1, 2},
                {3, 4}
           };

                int[,] b = {
                {5, 6},
                {7, 8}
            };

                int[,] C = new int[2, 2];


                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            C[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                Console.WriteLine("Resultado da multiplicação:");
                funcoes.ImprimaMatriz(C);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex06()
        {
            //6.Matriz Identidade Construa um programa que verifica se uma matriz quadrada é uma matriz identidade.
            try
            {
                int[,] x = new int[3, 3]
            {
                { 7, 2, 1 },
                { 4, 5, 6 },
                { 9, 8, 3 }
            };
                bool verificar = funcoes.EhIdentidade(x);
                Console.WriteLine(verificar);

                int[,] z = new int[3, 3]
                {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
                };
                bool verificarZ = funcoes.EhIdentidade(z);
                Console.WriteLine(verificarZ);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }

        }

        private static void ex05()
        {
            // 5.Transposta de uma Matriz Implemente um programa que gere a transposta de uma matriz 3x3.
            try
            {
                int[,] x = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
                funcoes.TransponhaMatriz(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex04()
        {
            //4. Diagonal Principal Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada.
            try
            {
                int[,] x = new int[4, 4]
            {
                { 7, 2, 1, 6 },
                { 4, 5, 6, 2 },
                { 9, 8, 3, 1 },
                { 4, 5, 6, 2 },
            };
                funcoes.ImprimaDiagonal(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex03()
        {
            //3.Maior e Menor Valor Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz.
            try
            {
                int[,] x = new int[3, 3]
            {
                { 7, 2, 1 },
                { 4, 5, 6 },
                { 9, 8, 3 }
            };
                (int menor, int maior) maiorMenor = funcoes.EncontreMaiorMenor(x);
                Console.WriteLine($"Maior = {maiorMenor.maior}");
                Console.WriteLine($"Menor = {maiorMenor.menor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }

        }

        private static void ex02()
        {
            //2. Soma dos Elementos Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos.
            try
            {
                int[,] x = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
                int soma = funcoes.SomarMatriz(x);
                Console.WriteLine(soma);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");

            }


        }

        private static void ex01()
        {
            //1.Criando uma Matriz Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos.
            try
            {
                int[,] x = new int[3, 3];
                int[,] matriz =
                {
                    {1,2,3},
                    {4,5,6},
                    {7,8,9}
                };
                funcoes.ImprimaMatriz(matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado{ex.Message}");
            }


        }
    }
}
