using System;

class Program
{
    // Método principal que é chamado quando o programa é executado.
    static void Main()
    {
        // Cria dois vetores 'vetorX' e 'vetorY' com 10 elementos cada.
        int[] vetorX = new int[10];
        int[] vetorY = new int[10];
        
        // Chama o procedimento para preencher os vetores com valores.
        PreencherVetores(vetorX, vetorY);
        
        // Chama o procedimento para intercalar os vetores em um novo vetor 'vetorIntercalado'.
        int[] vetorIntercalado = IntercalarVetores(vetorX, vetorY);
        
        // Chama o procedimento para exibir os valores do vetor intercalado.
        ExibirVetor(vetorIntercalado);

        Console.ReadLine();
        // Só paa nao fechar
    }

    // Procedimento para preencher dois vetores com valores aleatórios.
    static void PreencherVetores(int[] vetorX, int[] vetorY)
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            vetorX[i] = random.Next(0, 100); // Preenche 'vetorX' com números aleatórios entre 0 e 100.
            vetorY[i] = random.Next(0, 100); // Preenche 'vetorY' com números aleatórios entre 0 e 100.
        }
    }

    // Procedimento que recebe dois vetores e retorna um novo vetor com os elementos intercalados.
    static int[] IntercalarVetores(int[] vetorX, int[] vetorY)
    {
        int[] vetorIntercalado = new int[vetorX.Length + vetorY.Length];
        
        for (int i = 0; i < vetorIntercalado.Length; i++)
        {
            if (i % 2 == 0) // Se a posição for par...
            {
                vetorIntercalado[i] = vetorY[i / 2]; // ...pega elemento do 'vetorY'.
            }
            else // Se a posição for ímpar...
            {
                vetorIntercalado[i] = vetorX[i / 2]; // ...pega elemento do 'vetorX'.
            }
        }
        
        return vetorIntercalado; // Retorna o novo vetor intercalado.
    }

    // Procedimento para exibir os valores de um vetor.
    static void ExibirVetor(int[] vetor)
    {
        foreach (int valor in vetor) // Para cada valor no vetor...
        {
            Console.WriteLine(valor); // ...exibe o valor na tela.
        }
    }
}

