class Program
{ static void Main()
    {
        // Ler o número de valores a serem verificados
        Console.Write("Digite o número de valores a serem verificados: ");
        int N = int.Parse(Console.ReadLine());

        // Loop para ler N números e verificar se são positivos
        for (int i = 0; i < N; i++)
        {
            Console.Write($"\nDigite o {i+1}º valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            // Chamar a função para verificar se o valor é positivo
            bool positivo = VerificarPositivo(valor);

            // Exibir mensagem baseada no resultado da função
            if (positivo)
            {
                Console.WriteLine("O valor é positivo.");
            }
            else
            {
                Console.WriteLine("O valor é negativo ou zero.");
            }
        }
    }

    // Função para verificar se um valor inteiro é positivo
    static bool VerificarPositivo(int valor)
    {
        return valor > 0; // Retorna true se o valor for positivo, caso contrário retorna false
    }
}

