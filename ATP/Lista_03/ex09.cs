Console.WriteLine("Digite o valor limite para a soma dos elementos da série de Fibonacci: ");
        int l = int.Parse(Console.ReadLine());

        // Verifica se o usuário inseriu um número válido
        if (l < 1)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo maior que zero.");
            return;
        }

        // Declaração das variáveis para os números Fibonacci e para a soma
        int primeiro = 0;
        int segundo = 1;
        int proximo;
        int soma = 0;

        // Loop para calcular e exibir os próximos elementos da sequência até atingir o limite L
        while (true)
        {
            // Calcula o próximo número Fibonacci
            proximo = primeiro + segundo;

            // Verifica se o próximo número excede o limite L
            if (proximo >= l)
                break;

            // Adiciona o próximo número à soma
            soma += proximo;

            // Atualiza os valores para o próximo cálculo
            primeiro = segundo;
            segundo = proximo;
        }

        // Exibe a soma dos elementos da série de Fibonacci menores que L
        Console.WriteLine($"A soma de todos os elementos da série de Fibonacci menores que {l} é: {soma+=1}");
    
