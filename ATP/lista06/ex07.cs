using System;
using System.IO;

class InserirELerLetras
{
    static void Main()
    {
        // Solicita ao usuário a quantidade de letras a ser inserida
        Console.WriteLine("Quantas letras você deseja inserir?");
        int N;

        // Verifica se a entrada é válida
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo:");
        }

        // Solicita ao usuário para inserir N letras
        Console.WriteLine($"Digite {N} letras (uma por vez):");
        string caminhoArquivo = "letras.txt";

        try
        {
            using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
            {
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Letra {i + 1}: ");
                    string letra = Console.ReadLine();

                    // Verifica se a entrada é uma única letra
                    while (letra.Length != 1 || !char.IsLetter(letra[0]))
                    {
                        Console.WriteLine("Por favor, insira uma única letra:");
                        letra = Console.ReadLine();
                    }

                    // Escreve a letra no arquivo
                    escritor.Write(letra);
                }
            }

            Console.WriteLine($"As {N} letras foram salvas em '{caminhoArquivo}'.");

            // Lê as letras do arquivo e conta as vogais
            string conteudoArquivo = File.ReadAllText(caminhoArquivo);
            int contagemVogais = 0;

            foreach (char c in conteudoArquivo)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    contagemVogais++;
                }
            }

            // Exibe a quantidade de vogais
            Console.WriteLine($"O arquivo contém {contagemVogais} vogais.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao processar o arquivo: {e.Message}");
        }
    }
}

