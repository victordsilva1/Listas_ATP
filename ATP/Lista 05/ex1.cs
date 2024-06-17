class Program
{

    static void Main()
    {
    int[] N = new int [20];
    Console.WriteLine("Write 20 numbers (int) for the array N: ");
    
    for (int i = 0; i < N.Length; i++)
    {
        Console.WriteLine($"Vetor {i+1}: ");
        N[i]= int.Parse(Console.ReadLine());
    }
     // Inicializar o menor elemento como o primeiro do vetor
        int menorElemento = N[0];
        int posicaoMenor = 0;

        // Percorrer o vetor para encontrar o menor elemento e sua posição
        for (int i = 1; i < N.Length; i++)
        {
            if (N[i] < menorElemento)
            {
                menorElemento = N[i];
                posicaoMenor = ++i;
            }
        }

        // Mostrar o menor elemento e sua posição
        Console.WriteLine($"O menor elemento de N é: {menorElemento}, e sua posição dentro do vetor é: {posicaoMenor}");
    


    }
}
