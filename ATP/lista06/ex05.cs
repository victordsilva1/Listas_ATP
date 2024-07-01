using System;
using System.IO;

class LerArquivo
{
    static void Main()
    {
        // Solicita ao usuário que insira o caminho do arquivo
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminhoArquivo = Console.ReadLine();
        
        try
        {
            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            int contagemLinhas = linhas.Length;

            // Imprime cada linha do arquivo
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            // Exibe a quantidade de linhas
            Console.WriteLine($"O arquivo possui {contagemLinhas} linhas.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
        }
    }
}

