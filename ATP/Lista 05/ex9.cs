using System;

class Program
{
    static void Main()
    {
        // Declaração das matrizes A e B
        int[,] A = new int[4, 6];
        int[,] B = new int[4, 6];

        // Preenchimento das matrizes A e B
        Console.WriteLine("Preenchendo a matriz A:");
        PreencherMatriz(A);
        Console.WriteLine("Preenchendo a matriz B:");
        PreencherMatriz(B);

        // Exibindo as matrizes A e B
        Console.WriteLine("Matriz A:");
        ExibirMatriz(A);
        Console.WriteLine("Matriz B:");
        ExibirMatriz(B);

        // Calculando a matriz soma (S)
        int[,] S = SomarMatrizes(A, B);
        Console.WriteLine("Matriz Soma (S = A + B):");
        ExibirMatriz(S);

        // Calculando a matriz diferença (D)
        int[,] D = SubtrairMatrizes(A, B);
        Console.WriteLine("Matriz Diferença (D = A - B):");
        ExibirMatriz(D);
    }

    // Procedimento para preencher uma matriz
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para somar duas matrizes
    static int[,] SomarMatrizes(int[,] A, int[,] B)
    {
        int[,] S = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                S[i, j] = A[i, j] + B[i, j];
            }
        }
        return S;
    }

    // Função para subtrair duas matrizes
    static int[,] SubtrairMatrizes(int[,] A, int[,] B)
    {
        int[,] D = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                D[i, j] = A[i, j] - B[i, j];
            }
        }
        return D;
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
}

