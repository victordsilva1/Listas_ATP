using System;
using System.IO;

class Divisores
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.WriteLine("Digite um número:");
        int numero;

        // Verifica se a entrada é válida
        while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo:");
        }

        // Encontra e imprime os divisores
        Console.WriteLine($"Divisores de {numero}:");
        int somaDivisores = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
                somaDivisores += i;
            }
        }

        // Define o caminho do arquivo
        string caminhoArquivo = "sumdivisores.txt";

        // Salva a soma dos divisores em um arquivo
        try
        {
            using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
            {
                escritor.WriteLine($"Soma dos divisores de {numero}: {somaDivisores}");
            }

            Console.WriteLine($"A soma dos divisores foi salva em '{caminhoArquivo}'.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao salvar a soma dos divisores: {e.Message}");
        }
    }
}

