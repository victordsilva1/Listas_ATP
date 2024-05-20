using System;

class Program
{
    static void Main()
    {
        // Ler os dois números do teclado
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        // Chamar a função para calcular o MDC e exibir o resultado
        int mdc = CalcularMDC(num1, num2);
        Console.WriteLine($"O MDC de {num1} e {num2} é: {mdc}");
    }

    // Função para calcular o MDC usando o algoritmo de Euclides
    static int CalcularMDC(int a, int b)
    {
        // Enquanto b for diferente de zero, calculamos o resto da divisão de a por b
        // e atribuímos o valor de b a a e o resto a b.
        // Repetimos o processo até que b seja igual a zero, momento em que a será o MDC.
        while (b != 0)
        {
            int resto = a % b;
            a = b;
            b = resto;
        }
        return a; // Retornamos o valor de a, que é o MDC
    }
}

