using System;

class MatrizDiagonal
{
    static void Main()
    {
        // Declaração da matriz 4x4
        int[,] matriz = new int[4, 4];
        int somaAbaixoDiagonal = 0;

        // Preenchimento da matriz com números aleatórios
        PreencherMatriz(matriz);

        // Calcula a soma dos elementos abaixo da diagonal principal
        for (int i = 1; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                somaAbaixoDiagonal += matriz[i, j];
            }
        }

        // Exibe os elementos da diagonal principal e a soma dos elementos abaixo dela
        Console.WriteLine("Elementos da diagonal principal:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine("\nSoma dos elementos abaixo da diagonal principal: " + somaAbaixoDiagonal);
        Console.ReadLine();
    }

    // Procedimento para preencher a matriz com números aleatórios
    static void PreencherMatriz(int[,] m)
    {
        Random random = new Random();
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                m[i, j] = random.Next(1, 10); // Números aleatórios entre 1 e 10
            }
        }
    }
}

