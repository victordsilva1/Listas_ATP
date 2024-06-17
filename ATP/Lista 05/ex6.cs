using System;

class TemperaturasOutubro
{
    static void Main()
    {
        // Define o tamanho do vetor para 31 dias de outubro
        double[] temperaturas = new double[31];
        double somaTemperaturas = 0, mediaTemperatura;
        double menorTemperatura = 40; // Inicializa com a temperatura máxima possível
        double maiorTemperatura = 15; // Inicializa com a temperatura mínima possível
        int diasAbaixoMedia = 0;

        // Preenche o vetor com temperaturas aleatórias entre 15°C e 40°C para simplificar
        Random random = new Random();
        for (int i = 0; i < temperaturas.Length; i++)
        {
            // Gera uma temperatura aleatória entre 15 e 40
            temperaturas[i] = random.NextDouble() * (40 - 15) + 15;
            somaTemperaturas += temperaturas[i];

            // Verifica se a temperatura atual é a menor ou a maior
            if (temperaturas[i] < menorTemperatura) menorTemperatura = temperaturas[i];
            if (temperaturas[i] > maiorTemperatura) maiorTemperatura = temperaturas[i];
        }

        // Calcula a média das temperaturas
        mediaTemperatura = somaTemperaturas / temperaturas.Length;

        // Conta quantos dias tiveram temperatura abaixo da média
        foreach (double temperatura in temperaturas)
        {
            if (temperatura < mediaTemperatura) diasAbaixoMedia++;
        }

        // Imprime os resultados
        Console.WriteLine("Menor temperatura: " + menorTemperatura + "°C");
        Console.WriteLine("Maior temperatura: " + maiorTemperatura + "°C");
        Console.WriteLine("Temperatura média: " + mediaTemperatura + "°C");
        Console.WriteLine("Número de dias com temperatura abaixo da média: " + diasAbaixoMedia);

        Console.ReadLine();
    }
}

