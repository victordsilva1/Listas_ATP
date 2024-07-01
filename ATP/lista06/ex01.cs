using System;

class ContarEspacos
{
    static void Main()
    {
        // Solicita ao usuário que insira uma frase
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contagemEspacos = 0;

        // Conta espaços em branco na frase
        foreach (char c in frase)
        {
            if (char.IsWhiteSpace(c))
            {
                contagemEspacos++;
            }
        }

        // Exibe a quantidade de espaços em branco
        Console.WriteLine($"A frase contém {contagemEspacos} espaços em branco.");
    }
}
