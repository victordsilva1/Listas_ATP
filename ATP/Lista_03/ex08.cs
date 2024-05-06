Console.WriteLine("Número de elementos da sequência Fibonacci");

Console.WriteLine("Digite o número: ");
        int l = int.Parse(Console.ReadLine());

        // Verifica se o usuário inseriu um número válido
        if (l < 1)
        {
            Console.WriteLine("Insira um número inteiro positivo maior que zero.");
            return;
        }

        // Declaração das variáveis para os números Fibonacci
        int primeiro = 0;
        int segundo = 1;
        int proximo;

        // Exibe o primeiro elemento
        Console.Write($"{primeiro} ");

        // Loop para calcular e exibir os próximos elementos da sequência
        for (int i = 1; i < l; i++)
        {
            // Calcula o próximo número Fibonacci
            proximo = primeiro + segundo;

            // Exibe o próximo número
            Console.Write($"{proximo} ");

            // Atualiza os valores para o próximo cálculo
            primeiro = segundo;
            segundo = proximo;
        }

        // Pula uma linha após exibir todos os elementos
        Console.WriteLine();
    
