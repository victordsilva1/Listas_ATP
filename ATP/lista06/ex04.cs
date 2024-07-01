using System;
using System.IO;

class ContadordeA
{
    static void Main()
    {
        // Solicita ao usuário que insira o caminho do arquivo
        Console.WriteLine("Digite o caminho do arquivo:");
        string caminhoArquivo = Console.ReadLine();
        
        try
        {
            // Lê todo o conteúdo do arquivo
            string conteudo = File.ReadAllText(caminhoArquivo);
            int contagem = 0;

            // Conta os caracteres 'a' e 'A' no conteúdo
            foreach (char c in conteudo)
            {
                if (c == 'a' || c == 'A')
                {
                    contagem++;
                }
            }

            // Exibe a quantidade de caracteres 'a'
            Console.WriteLine($"O arquivo contém {contagem} caracteres 'a'.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
        }
    }
}

