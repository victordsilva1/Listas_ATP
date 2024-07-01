using System;

class CodigoCesar
{
    static void Main()
    {
        // Solicita ao usuário que insira uma string
        Console.WriteLine("Digite uma string:");
        string entrada = Console.ReadLine();

        string resultado = "";

        // Codifica cada caractere usando o Código de César (desloca 3 posições)
        foreach (char c in entrada)
        {
            if (char.IsLetter(c))
            {
                char deslocado = (char)(c + 3);
                
                // Ajusta o deslocamento para dentro dos limites do alfabeto
                if (char.IsLower(c) && deslocado > 'z' || char.IsUpper(c) && deslocado > 'Z')
                {
                    deslocado = (char)(deslocado - 26);
                }

                resultado += deslocado;
            }
            else
            {
                resultado += c;
            }
        }

        // Exibe a string codificada em maiúsculas
        Console.WriteLine($"String codificada: {resultado.ToUpper()}");
    }
}

