using System;

namespace MinhaBiblioteca
{
    public class Biblioteca
    {
        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("Entre com os dados da matriz");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i}],[{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }
        public static void gerarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Random rand = new Random();
            Console.WriteLine("gerando matriz... ");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = rand.Next(100);
                }

            }
        }
        public static void escreveMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            Console.WriteLine("*** Matriz ***");
            for (int i = 0; i < linhas; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matriz[i, j] + " | ");
                }
                Console.WriteLine();

            }
        }
        public static int menorMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            int mnr = matriz[0,0];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matriz[i, j] < mnr)
                    {
                        mnr = matriz[i, j];
                    }
                }
            }
            return mnr;
        }
        public static int maiorMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);
            int mnr = matriz[0,0];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matriz[i, j] > mnr)
                    {
                        mnr = matriz[i, j];
                    }
                }
            }
            return mnr;
        }
    }
}