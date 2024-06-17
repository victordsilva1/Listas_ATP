using System;

class Program
{
    static void Main()
    {
        // Declaração da matriz M
        int[,] M = new int[10, 10];

        // Preenchimento e exibição da matriz M
        PreencherMatriz(M);
        Console.WriteLine("Matriz Original:");
        ExibirMatriz(M);

        // Troca da linha 2 com a linha 8
        SwapRows(M, 2, 8);
        Console.WriteLine("Matriz após trocar linha 2 com linha 8:");
        ExibirMatriz(M);

        // Troca da coluna 4 com a coluna 10
        SwapColumns(M, 4, 10);
        Console.WriteLine("Matriz após trocar coluna 4 com coluna 10:");
        ExibirMatriz(M);

        // Troca da diagonal principal com a diagonal secundária
        SwapDiagonals(M);
        Console.WriteLine("Matriz após trocar diagonal principal com diagonal secundária:");
        ExibirMatriz(M);

        // Troca da linha 5 com a coluna 10
        SwapRowColumn(M, 5, 10);
        Console.WriteLine("Matriz após trocar linha 5 com coluna 10:");
        ExibirMatriz(M);
        Console.ReadLine();
    }

    // Procedimento para preencher uma matriz
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Digite o valor para a posição [{i + 1}, {j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Procedimento para exibir uma matriz
    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Procedimento para trocar duas linhas na matriz
    static void SwapRows(int[,] matrix, int row1, int row2)
    {
        row1--; row2--; // Ajuste para índice baseado em 0
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int temp = matrix[row1, i];
            matrix[row1, i] = matrix[row2, i];
            matrix[row2, i] = temp;
        }
    }

    // Procedimento para trocar duas colunas na matriz
    static void SwapColumns(int[,] matrix, int col1, int col2)
    {
        col1--; col2--; // Ajuste para índice baseado em 0
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária
    static void SwapDiagonals(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, i];
            matrix[i, i] = matrix[i, matrix.GetLength(0) - 1 - i];
            matrix[i, matrix.GetLength(0) - 1 - i] = temp;
        }
    }

    // Procedimento para trocar uma linha com uma coluna na matriz
    static void SwapRowColumn(int[,] matrix, int row, int col)
    {
        row--; col--; // Ajuste para índice baseado em 0
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[row, i];
            matrix[row, i] = matrix[i, col];
            matrix[i, col] = temp;
        }
    }
}

