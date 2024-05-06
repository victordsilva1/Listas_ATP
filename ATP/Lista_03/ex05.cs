Console.WriteLine("Digite um valor inteiro e positivo para N: ");
        int N = int.Parse(Console.ReadLine());

        if (N >= 0)
        {
            double E = CalcularE(N);
            Console.WriteLine($"O valor de E é: {E}");
        }
        else
        {
            Console.WriteLine("Por favor, digite um valor inteiro e positivo para N.");
        }
    

    static double CalcularE(int N){
    
        double E = 1.0; // Começa com 1 para incluir o primeiro termo (1 / 0!)
        double fatorial = 1.0;

        for (int i = 1; i <= N; i++)
        {
            fatorial *= i;
            E += 1.0 / fatorial;
        }

        return E;
    }
