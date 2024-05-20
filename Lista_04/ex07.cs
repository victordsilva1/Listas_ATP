using System;

class Program
{
    static void Main()
    {
        // Ler o número de alunos
        Console.Write("Digite o número de alunos: ");
        int N = int.Parse(Console.ReadLine());

        // Loop para ler a média de cada aluno e calcular o conceito
        for (int i = 0; i < N; i++)
        {
            Console.Write($"\nDigite a média final do aluno {i + 1}: ");
            double media = double.Parse(Console.ReadLine());

            // Chamar o procedimento para identificar o conceito e exibi-lo
            IdentificarConceito(media);
        }
    }

    // Procedimento para identificar e exibir o conceito com base na média final
    static void IdentificarConceito(double media)
    {
        char conceito;

        if (media >= 90)
        {
            conceito = 'A';
        }
        else if (media >= 80)
        {
            conceito = 'B';
        }
        else if (media >= 70)
        {
            conceito = 'C';
        }
        else if (media >= 60)
        {
            conceito = 'D';
        }
        else if (media >= 40)
        {
            conceito = 'E';
        }
        else
        {
            conceito = 'F';
        }

        Console.WriteLine($"Conceito: {conceito}");
    }
}

