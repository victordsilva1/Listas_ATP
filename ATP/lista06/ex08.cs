using System;
using System.IO;

class LocadoraVeiculos
{
    static void Main()
    {
        // Solicita ao usuário a quantidade de veículos
        Console.WriteLine("Digite a quantidade de veículos que a locadora possui:");
        int quantidadeVeiculos;

        // Verifica se a entrada é válida
        while (!int.TryParse(Console.ReadLine(), out quantidadeVeiculos) || quantidadeVeiculos <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo:");
        }

        // Solicita ao usuário o valor do aluguel por veículo
        Console.WriteLine("Digite o valor que a locadora cobra por cada aluguel:");
        decimal valorAluguel;

        // Verifica se a entrada é válida
        while (!decimal.TryParse(Console.ReadLine(), out valorAluguel) || valorAluguel <= 0)
        {
            Console.WriteLine("Por favor, digite um valor positivo:");
        }

        // Calcula o faturamento mensal
        decimal faturamentoMensal = (quantidadeVeiculos * valorAluguel) / 3;
        // Calcula o faturamento anual
        decimal faturamentoAnual = faturamentoMensal * 12;

        // Calcula o valor ganho com multas no mês
        decimal valorMultasMensal = (faturamentoMensal / 10) * 0.2m;

        // Calcula o valor gasto com manutenção anual
        decimal valorManutencaoAnual = (quantidadeVeiculos * 0.02m) * 600;

        // Exibe os resultados na tela
        Console.WriteLine($"Faturamento mensal: R$ {faturamentoMensal:F2}");
        Console.WriteLine($"Faturamento anual: R$ {faturamentoAnual:F2}");
        Console.WriteLine($"Valor ganho com multas no mês: R$ {valorMultasMensal:F2}");
        Console.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");

        // Grava os resultados em um arquivo
        string caminhoArquivo = "resultado.txt";

        try
        {
            using (StreamWriter escritor = new StreamWriter(caminhoArquivo))
            {
                escritor.WriteLine($"Faturamento mensal: R$ {faturamentoMensal:F2}");
                escritor.WriteLine($"Faturamento anual: R$ {faturamentoAnual:F2}");
                escritor.WriteLine($"Valor ganho com multas no mês: R$ {valorMultasMensal:F2}");
                escritor.WriteLine($"Valor gasto com manutenção anual: R$ {valorManutencaoAnual:F2}");
            }

            Console.WriteLine($"Os resultados foram salvos em '{caminhoArquivo}'.");
        }
        catch (Exception e)
        {
            // Exibe mensagem de erro em caso de exceção
            Console.WriteLine($"Erro ao salvar os resultados: {e.Message}");
        }
    }
}

