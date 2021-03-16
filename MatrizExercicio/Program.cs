using System;

namespace MatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de Colunas: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Digite um número de Linhas: ");
            int N = int.Parse(Console.ReadLine()) - 1;

            int[,] mat = new int[M, N];

            Console.WriteLine($"Digite o valor das linhas ({M} números por linha):");

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite o valor a ser procurado: ");
            int Valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i,j] == Valor)
                    {
                        Console.WriteLine("Posição: " + i + ", " + j);
                        if (j != 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        } 
                        if(j != (N - 1))
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i != 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (i != (M - 1))
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        
    }
}
