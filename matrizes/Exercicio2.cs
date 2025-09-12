using System;
using MinhaBiblioteca;

class Exercicio2
{
    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];
        Biblioteca.gerarMatriz(matriz);
        Biblioteca.escreveMatriz(matriz);
        Console.WriteLine("O maior valor é: "+Biblioteca.maiorMatriz(matriz));
    }
}