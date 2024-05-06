// Variáveis para armazenar os dados da pesquisa
        double somaSalarios = 0;
        int somaFilhos = 0;
        double maiorSalario = 0;
        int contadorSalarioAte100 = 0;
        int totalHabitantes = 0;

        // Solicita o salário do primeiro habitante
        Console.WriteLine("Digite o salário do habitante 1 (digite um valor negativo para encerrar): ");
        double salario = double.Parse(Console.ReadLine());

        // Loop para entrada dos dados dos habitantes
        while (salario >= 0)
        {
            // Incrementa o total de habitantes
            totalHabitantes++;
            
            // Adiciona o salário à soma total de salários
            somaSalarios += salario;

            // Verifica se o salário é o maior até agora
            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            // Solicita o número de filhos do habitante
            Console.WriteLine($"Informe o número de filhos do habitante {totalHabitantes}: ");
            int numFilhos = int.Parse(Console.ReadLine());
            
            // Adiciona o número de filhos à soma total de filhos
            somaFilhos += numFilhos;

            // Verifica se o salário está abaixo de R$100,00
            if (salario <= 100)
            {
                contadorSalarioAte100++;
            }

            // Solicita o salário do próximo habitante ou encerra o loop se for inserido um valor negativo
            Console.WriteLine($"Digite o salário do habitante {totalHabitantes + 1} (digite um valor negativo para encerrar): ");
            salario = double.Parse(Console.ReadLine());
        }

        // Verifica se pelo menos um habitante foi inserido
        if (totalHabitantes > 0)
        {
            // Calcula as médias de salário e de número de filhos
            double mediaSalario = somaSalarios / totalHabitantes;
            double mediaFilhos = (double)somaFilhos / totalHabitantes;
            
            // Calcula o percentual de pessoas com salário até R$100,00
            double percentualSalarioAte100 = (double)contadorSalarioAte100 / totalHabitantes * 100;

            // Imprime os resultados da pesquisa
            Console.WriteLine($"A média do salário da população é: {mediaSalario:C}");
            Console.WriteLine($"A média do número de filhos é: {mediaFilhos:F}");
            Console.WriteLine($"O maior salário é: {maiorSalario:C}");
            Console.WriteLine($"O percentual de pessoas com salário até R$100,00 é: {percentualSalarioAte100:F}%");
        }
        else
        {
            // Se nenhum habitante foi inserido, exibe uma mensagem de aviso
            Console.WriteLine("Nenhum dado foi inserido.");
        }
