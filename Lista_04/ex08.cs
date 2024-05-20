
class Program
{
    static void Main()
    {
        // Ler o valor de N do teclado
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        // Chamar a função para calcular o valor de S e imprimir o resultado
        double resultado = CalcularS(N);
        Console.WriteLine($"O valor de S é: {resultado}");
    }

    // Função para calcular o valor de S
    static double CalcularS(int N)
    {
        double S = 0;

        for (int n = 1; n <= N; n++)
        {
            // Calcula o numerador e o denominador da fração
            int numerador = n * n + 1;
            int denominador = n + 3;

            // Adiciona o resultado da fração ao valor de S
            S += (double)numerador / denominador;
        }

        return S;
    }
}

