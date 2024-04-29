using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Criação de uma matriz:");
            Console.WriteLine("Digite o número de linhas:");
            int linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            Console.WriteLine("Preencha a matriz com " + linhas + " por coluna");

            int[,] mat = new int[linhas,colunas];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] recebe = Console.ReadLine().Split(' ');

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i,j] = int.Parse(recebe[j]);
                }

            }

            Console.WriteLine("Digite um número que exista na matriz");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                

                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Posição é " + i + ", " + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }

                        if (j < mat.GetLength(1)-1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }

                        if (i > 0)
                        {

                            Console.WriteLine("Cima: " + mat[i-1, j]);

                        }

                        if (i < mat.GetLength(0)-1)
                        {
                            Console.WriteLine("Baixo: "+mat[i+1,j]); ;
                        }
                    }
                }

            }




        }
    }
}
