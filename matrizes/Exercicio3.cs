using System;
using MinhaBiblioteca;

class Exercicio3
{
    static void Main()
    {
        int linhas, cols, x, c=0;
        Console.WriteLine("Entre com a quantidade de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];
        Console.WriteLine("Entre com o valor de X");
        x = int.Parse(Console.ReadLine());
        Biblioteca.gerarMatriz(matriz);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == x)
                {
                    c++;
                }
            }

        }
        Biblioteca.escreveMatriz(matriz);
        Console.WriteLine("O valor de X pararece: "+c+" vez(es)");
    }
}