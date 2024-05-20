class Program
{
    static void Main()
    {
        // Ler o número de alunos
        Console.Write("Digite o número de alunos: ");
        int numeroAlunos = int.Parse(Console.ReadLine());

        // Chamar a função para calcular a média das notas dos alunos aprovados
        double mediaAprovados = CalcularMediaAprovados(numeroAlunos);
        
        // Imprimir a média dos alunos aprovados
        Console.WriteLine($"A média das notas dos alunos aprovados é: {mediaAprovados}");
    }

    // Função para calcular a média das notas dos alunos aprovados
    static double CalcularMediaAprovados(int numeroAlunos)
    {
        double somaNotasAprovados = 0;
        int quantidadeAprovados = 0;

        // Loop para ler as notas dos alunos e calcular a média dos aprovados
        for (int i = 0; i < numeroAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1}: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                somaNotasAprovados += nota;
                quantidadeAprovados++;
            }
        }

        // Verificar se há alunos aprovados para evitar divisão por zero
        if (quantidadeAprovados > 0)
        {
            return somaNotasAprovados / quantidadeAprovados;
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi aprovado.");
            return 0;
        }
    }
}

