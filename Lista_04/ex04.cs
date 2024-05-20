class Program
{
    static void Main()
    {
        // Loop para ler triângulos indeterminados
        while (true)
        {
            // Ler os três valores do teclado
            Console.WriteLine("\nDigite os comprimentos dos três lados do triângulo (ou digite 0 para sair):");
            Console.Write("Lado 1: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            double z = double.Parse(Console.ReadLine());

            // Verificar se o usuário deseja sair
            if (x == 0 || y == 0 || z == 0)
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }

            // Chamar o procedimento para verificar o tipo de triângulo
            VerificarTipoTriangulo(x, y, z);
        }
    }

    // Procedimento para verificar o tipo de triângulo
    static void VerificarTipoTriangulo(double x, double y, double z)
    {
        // Verificar se os valores formam um triângulo
        if (x < y + z && y < x + z && z < x + y)
        {
            // Verificar o tipo de triângulo
            if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero.");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Triângulo Isósceles.");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo.");
        }
    }
}

