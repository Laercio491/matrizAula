using System;
using MinhaBiblioteca;

class Matriz
{
    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];
        Biblioteca.lerMatriz(matriz);
        Biblioteca.escreveMatriz(matriz);
    }
}