using System;
using MinhaBiblioteca;

class Exercicio8
{
    static int contRaio(int[,] matriz)
    {
        int cont = 0;
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > 1)
                {
                    cont++;
                }
            }

        }

        return cont;
    }
    static void Main()
    {
        int linhas, cols;
        int x, y, quantR;
        Console.WriteLine("Entre com a quantidade de linhas e colunas da area");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] mapa = new int[linhas, cols];
        Console.WriteLine("Quantos raios foram anotados: ");
        quantR = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantR; i++)
        {
            Console.WriteLine("Cordenadas dos raios: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;
        }
        Biblioteca.escreveMatriz(mapa);
        Console.WriteLine($"Houve(ram) {contRaio(mapa)} raio(s) na mesma região");
    }
}