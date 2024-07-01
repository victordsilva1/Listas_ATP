using System;
using System.Collections.Generic;
using System.IO;

class GerenciarAlunos
{
    static void Main()
    {
        string caminhoArquivo = "dados_alunos.txt";
        int opcao;

        do
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Armazenar dados de alunos");
            Console.WriteLine("2. Ler dados de alunos");
            Console.WriteLine("3. Sair");
            Console.Write("Opção: ");

            // Verifica se a entrada é válida
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
            {
                Console.WriteLine("Opção inválida. Tente novamente:");
            }

            switch (opcao)
            {
                case 1:
                    ArmazenarDados(caminhoArquivo);
                    break;
                case 2:
                    LerDados(caminhoArquivo);
                    break;
                case 3:
                    Console.WriteLine("Saindo do programa...");
                    break;
            }

        } while (opcao != 3);
    }

    // Método para armazenar dados dos alunos
    static void ArmazenarDados(string caminhoArquivo)
    {
        List<Aluno> alunos = new List<Aluno>();
        string continuar;

        do
        {
            Console.WriteLine("\nInsira os dados do aluno:");

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            alunos.Add(new Aluno(matricula, telefone));

            Console.WriteLine("Deseja adicionar mais um aluno? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        // Armazena os dados no arquivo
        try
        {
            using (StreamWriter escritor = new StreamWriter(caminhoArquivo, append: true))
            {
                foreach (var aluno in alunos)
                {
                    escritor.WriteLine($"{aluno.Matricula};{aluno.Telefone}");
                }
            }

            Console.WriteLine("Dados armazenados com sucesso.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao armazenar os dados: {e.Message}");
        }
    }

    // Método para ler dados dos alunos
    static void LerDados(string caminhoArquivo)
    {
        try
        {
            using (StreamReader leitor = new StreamReader(caminhoArquivo))
            {
                string linha;
                Console.WriteLine("\nDados dos alunos armazenados:");

                while ((linha = leitor.ReadLine()) != null)
                {
                    var dados = linha.Split(';');
                    if (dados.Length == 2)
                    {
                        Console.WriteLine($"Matrícula: {dados[0]}, Telefone: {dados[1]}");
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            // Exibe mensagem caso o arquivo não exista
            Console.WriteLine("Nenhum dado armazenado ainda. O arquivo não foi encontrado.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao ler os dados: {e.Message}");
        }
    }
}

// Classe para representar um aluno
class Aluno
{
    public string Matricula { get; set; }
    public string Telefone { get; set; }

    public Aluno(string matricula, string telefone)
    {
        Matricula = matricula;
        Telefone = telefone;
    }
}

