class Program
{
    static void Main()
    {

        Calchab();

    }

    static void Calchab()
    {
        double somaSalarios = 0;
        int contador = 0;

        while (true)
        {
            Console.Write("Digite o salário (ou um valor negativo para sair): ");
            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 0)
            {
                if (contador == 0)
                {
                    Console.WriteLine("Nenhum dado foi inserido.");
                }
                else
                {
                    double mediaSalario = somaSalarios / contador;
                    Console.WriteLine($"A média de salário da população é: {mediaSalario:C}");
                }
                break;
            }

            Console.Write("Digite o número de filhos: ");
            int numeroFilhos = Convert.ToInt32(Console.ReadLine());

            somaSalarios += salario;
            contador++;
        
        }
    }
}
