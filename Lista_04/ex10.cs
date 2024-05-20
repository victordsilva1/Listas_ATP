class Program{
    static void Main()
    {
        // Ler a idade do nadador
        Console.Write("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());

        // Chamar a função para obter a categoria do nadador e imprimir o resultado
        char categoria = ObterCategoriaNadador(idade);
        Console.WriteLine($"Categoria do nadador: {categoria}");
    }

    // Função para obter a categoria do nadador
    static char ObterCategoriaNadador(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return 'F';
        }
        else if (idade >= 8 && idade <= 10)
        {
            return 'E';
        }
        else if (idade >= 11 && idade <= 13)
        {
            return 'D';
        }
        else if (idade >= 14 && idade <= 15)
        {
            return 'C';
        }
        else if (idade >= 16 && idade <= 17)
        {
            return 'B';
        }
        else if (idade > 18)
        {
            return 'A';
        }
        else
        {
            return ' '; // Retorna um espaço em branco se a idade não estiver dentro das faixas especificadas
        }
    }
}

