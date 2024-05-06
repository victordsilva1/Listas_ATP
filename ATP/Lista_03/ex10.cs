// Variáveis para contabilizar as estatísticas
        int lucroMenor10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaior20 = 0;
        double valorCompraTotal = 0;
        double valorVendaTotal = 0;

        // Loop para inserção dos preços de compra e venda
        while (true)
        {
            Console.WriteLine("Informe o preço de compra (digite 0 para encerrar): ");
            double precoCompra = double.Parse(Console.ReadLine());

            // Verifica se o usuário deseja encerrar a entrada de dados
            if (precoCompra == 0)
                break;

            // Preço de compra igual a zero não é válido
            if (precoCompra < 0)
            {
                Console.WriteLine("O preço de compra não pode ser negativo. Insira novamente.");
                continue;
            }

            Console.WriteLine("Informe o preço de venda: ");
            double precoVenda = double.Parse(Console.ReadLine());

            // Verifica se o preço de venda é válido
            if (precoVenda < 0)
            {
                Console.WriteLine("O preço de venda não pode ser negativo. Insira novamente.");
                continue;
            }

            // Calcula o lucro
            double lucro = precoVenda - precoCompra;

            // Atualiza os valores totais de compra e venda
            valorCompraTotal += precoCompra;
            valorVendaTotal += precoVenda;

            // Determina em qual categoria de lucro o item se encaixa
            if (lucro < 0.1 * precoCompra)
                lucroMenor10++;
            else if (lucro <= 0.2 * precoCompra)
                lucroEntre10e20++;
            else
                lucroMaior20++;
        }

        // Calcula o lucro total
        double lucroTotal = valorVendaTotal - valorCompraTotal;

        // Exibe os resultados
        Console.WriteLine("Quantidade de mercadorias:");
        Console.WriteLine($"- Lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"- 10% <= Lucro <= 20%: {lucroEntre10e20}");
        Console.WriteLine($"- Lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: {valorCompraTotal:C}");
        Console.WriteLine($"Valor total de venda: {valorVendaTotal:C}");
        Console.WriteLine($"Lucro total: {lucroTotal:C}");
