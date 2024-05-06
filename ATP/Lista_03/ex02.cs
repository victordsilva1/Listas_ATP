Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");
        string entrada = Console.ReadLine();
        string[] valoresString = entrada.Split(' ');
        int[] valores = new int[valoresString.Length];

        // Convertendo os valores de string para int
        for (int i = 0; i < valoresString.Length; i++)
        {
            valores[i] = int.Parse(valoresString[i]);
        }

        int totalValores = valores.Length;
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        // Contando os valores positivos, negativos e zeros
        foreach (int valor in valores)
        {
            if (valor > 0)
            {
                positivos++;
            }
            else if (valor < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        double percentualPositivos = (double)positivos / totalValores * 100;
        double percentualNegativos = (double)negativos / totalValores * 100;
        double percentualZeros = (double)zeros / totalValores * 100;

        Console.WriteLine("Percentual de valores positivos: " + percentualPositivos.ToString("F2") + "%");
        Console.WriteLine("Percentual de valores negativos: " + percentualNegativos.ToString("F2") + "%");
        Console.WriteLine("Percentual de zeros: " + percentualZeros.ToString("F2") + "%");
