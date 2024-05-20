using System;

class Program
{
    static void Main()
    {
        // Ler o valor de N do teclado
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        // Loop para ler N conjuntos de valores
        for (int i = 0; i < N; i++)
        {
            // Ler os três valores do teclado
            Console.WriteLine($"\nConjunto {i + 1}:");
            Console.Write("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            int c = int.Parse(Console.ReadLine());

            // Chamar o procedimento para exibir os valores em ordem crescente
            ExibirOrdemCrescente(a, b, c);
        }
    }

    // Procedimento para exibir os valores em ordem crescente
    static void ExibirOrdemCrescente(int a, int b, int c)
    {
        // Ordenar os valores em ordem crescente
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        if (b > c)
        {
            int temp = b;
            b = c;
            c = temp;
        }
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Exibir os valores ordenados
        Console.WriteLine($"Valores em ordem crescente: {a}, {b}, {c}");
    }
}

