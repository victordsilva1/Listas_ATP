using System;

namespace helloworldd
{
    internal class Program
    {
        // Método principal que é chamado quando o programa é executado.
        static void Main(string[]args)
        {
            int[] numerosSorteados = SortearNumeros(); // Chama a função que sorteia 3 números.

            Console.WriteLine("Tente acertar um dos números sorteados entre 10 e 50.");

            while (true) // Loop infinito até que o usuário acerte um número.
            {
                Console.Write("Digite sua tentativa: ");
                int tentativa = Convert.ToInt32(Console.ReadLine());

                if (Array.Exists(numerosSorteados, elemento => elemento == tentativa)) // Verifica se a tentativa está entre os números sorteados.
                {
                    Console.WriteLine("Parabéns! Você acertou.");
                    break; // Sai do loop se acertar.
                }
                else
                {
                    Console.WriteLine("Tente novamente.");
                }
            }
        }

        // Função que sorteia 3 números entre 10 e 50 e retorna em um vetor.
        static int[] SortearNumeros()
        {
            Random random = new Random();
            int[] numerosSorteados = new int[3];

            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                numerosSorteados[i] = random.Next(10, 51); // Sorteia um número entre 10 e 50.
            }

            return numerosSorteados; // Retorna o vetor com os números sorteados.
        }
    }
}
