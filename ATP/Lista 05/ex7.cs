using System;

class MatrizOperacoes
{
    static void Main()
    {
        // Declaração da matriz 5x5
        int[,] matriz = new int[5, 5];

        // Preenchimento da matriz
        PreencherMatriz(matriz);

        // Exibindo as somas solicitadas
        Console.WriteLine("Soma da linha 4: " + SomaLinha(matriz, 4));
        Console.WriteLine("Soma da coluna 2: " + SomaColuna(matriz, 2));
        Console.WriteLine("Soma da diagonal principal: " + SomaDiagonalPrincipal(matriz));
        Console.WriteLine("Soma da diagonal secundária: " + SomaDiagonalSecundaria(matriz));
        Console.WriteLine("Soma de todos os elementos da matriz: " + SomaTotal(matriz));
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

    // Função para calcular a soma da linha especificada
    static int SomaLinha(int[,] m, int linha)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(1); i++)
        {
            soma += m[linha, i];
        }
        return soma;
    }

    // Função para calcular a soma da coluna especificada
    static int SomaColuna(int[,] m, int coluna)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, coluna];
        }
        return soma;
    }

    // Função para calcular a soma da diagonal principal
    static int SomaDiagonalPrincipal(int[,] m)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, i];
        }
        return soma;
    }

    // Função para calcular a soma da diagonal secundária
    static int SomaDiagonalSecundaria(int[,] m)
    {
        int soma = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            soma += m[i, m.GetLength(1) - 1 - i];
        }
        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaTotal(int[,] m)
    {
        int soma = 0;
        foreach (int elemento in m)
        {
            soma += elemento;
        }
        return soma;
    }
}

