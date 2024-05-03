Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");
string entrada = Console.ReadLine();
string[] valoresString = entrada.Split(' ');
int[] valores = new int[valoresString.Length];

// Convertendo os valores de string para int
for (int i = 0; i < valoresString.Length; i++)
{
    valores[i] = int.Parse(valoresString[i]);
}

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

Console.WriteLine("Número de valores positivos: " + positivos);
Console.WriteLine("Número de valores negativos: " + negativos);
Console.WriteLine("Número de zeros: " + zeros);



