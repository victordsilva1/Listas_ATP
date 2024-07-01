using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "/home/victorsilva/Documentos/ex010kk"; // Muda pro seu

        // Verifica se o arquivo existe
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        // Lê todas as linhas do arquivo
        string[] lines = File.ReadAllLines(filePath);

        // Array para armazenar os números convertidos
        double[] numbers = new double[lines.Length];

        // Converte as linhas para números em ponto flutuante
        for (int i = 0; i < lines.Length; i++)
        {
            if (double.TryParse(lines[i], out double number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine($"Erro ao converter linha {i + 1}: '{lines[i]}' não é um número válido.");
                return;
            }
        }

        // Verifica se há números no arquivo
        if (numbers.Length == 0)
        {
            Console.WriteLine("Nenhum número encontrado no arquivo.");
            return;
        }

        // Calcula o valor máximo, mínimo e média
        double max = numbers.Max();
        double min = numbers.Min();
        double media = numbers.Average();

        // Imprime os resultados
        Console.WriteLine($"Valor máximo: {max}");
        Console.WriteLine($"Valor mínimo: {min}");
        Console.WriteLine($"Média: {media}");
    }
}

