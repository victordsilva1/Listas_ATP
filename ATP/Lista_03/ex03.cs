int div39 = 0; // Contador para números divisíveis por 3 e 9
        int div25 = 0; // Contador para números divisíveis por 2 e 5

        // Loop para receber os 10 números
        for (int l = 0; l < 10; l++)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número é divisível por 3 e 9 ao mesmo tempo
            if (numero % 3 == 0 && numero % 9 == 0)
            {
                div39++; // Incrementa o contador
            }
           
            // Verifica se o número é divisível por 2 e 5 ao mesmo tempo
            if (numero % 2 == 0 && numero % 5 == 0)
            {
                div25++; // Incrementa o contador
            }

            // Verifica se o número não é divisível por nenhum dos conjuntos
            if ((numero % 3 != 0 || numero % 9 != 0) && (numero % 2 != 0 || numero % 5 != 0))
            {
                Console.WriteLine("Número " + numero + " não é divisível pelos valores.");
            }
        }

        // Exibe a quantidade de números divisíveis por 3 e 9
        Console.WriteLine("Quantidade de números divisíveis por 3 e 9: " + div39);

        // Exibe a quantidade de números divisíveis por 2 e 5
        Console.WriteLine("Quantidade de números divisíveis por 2 e 5: " + div25);
