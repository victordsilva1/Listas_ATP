// Inicialização das variáveis para contar os votos
        int[] votosCandidatos = new int[4]; // Índices 0 a 3 representam os candidatos 1 a 4
        int votosNulos = 0;
        int votosEmBranco = 0;

        // Loop para ler os votos até que o valor 0 seja inserido
        while (true)
        {
            Console.WriteLine("Digite o código do candidato (1 a 4), 5 para voto nulo, 6 para voto em branco ou 0 para encerrar: ");
            int voto = int.Parse(Console.ReadLine());

            // Verifica se o voto é válido
            if (voto == 0)
                break; // Encerra o loop se o valor inserido for 0
            else if (voto >= 1 && voto <= 4)
                votosCandidatos[voto - 1]++; // Incrementa o contador do candidato correspondente
            else if (voto == 5)
                votosNulos++; // Incrementa o contador de votos nulos
            else if (voto == 6)
                votosEmBranco++; // Incrementa o contador de votos em branco
            else
                Console.WriteLine("Código inválido. Insira novamente.");
        }

        // Exibe o total de votos para cada candidato
        Console.WriteLine("Total de votos para cada candidato:");
        for (int i = 0; i < votosCandidatos.Length; i++)
        {
            Console.WriteLine($"Candidato {i + 1}: {votosCandidatos[i]} votos");
        }

        // Exibe o total de votos nulos e em branco
        Console.WriteLine($"Total de votos nulos: {votosNulos}");
        Console.WriteLine($"Total de votos em branco: {votosEmBranco}");
