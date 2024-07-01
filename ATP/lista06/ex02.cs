using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma frase
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        
        string resultado = "";

        // Remove vogais da frase
        foreach (char c in frase)
        {
            if (!"aeiouAEIOU".Contains(c))
            {
                resultado += c;
            }
        }

        // Exibe a frase sem vogais
        Console.WriteLine($"Frase sem vogais: {resultado}");
    }
}
