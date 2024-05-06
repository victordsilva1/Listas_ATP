
        Console.WriteLine("Digite um valor inteiro e positivo para n: ");
        int n = int.Parse(Console.ReadLine());

        // Inicializa a variável S como 0
        double S = 0;

        // Loop para calcular cada termo da soma
        for (int i = 1; i <= n; i++)
        {
        
            // Calcula o termo atual (1/i) e adiciona a S
            double termo = 1.0 / i;
            S += termo;

            // Escreve o termo atual
            Console.WriteLine($"Termo {i}: {termo}");
        }
        if (0>=n)
        {
            Console.WriteLine("Insira somente numeros positivos e maior que 0");
            return;
        }
        // Escreve o valor final de S
        Console.WriteLine($"O valor final de S é: {S+=1}");
