using System;

class Program
{
    static void Main(string[] args)
    {
        int th;
        double somaSalarios = 0;
        int somaFilhos = 0;
        double maiorSalario = 0;
        int contadorSalarioAte100 = 0;

        Console.WriteLine("Digite o número total de habitantes: ");
        th = int.Parse(Console.ReadLine());

        for (int i = 1; i <= th; i++) //Enquanto nao informar o dado de cada habitante o programa nao acaba 
        {
            Console.WriteLine($"Informe o salário do habitante {i}: ");
            //Vai falar cada habitante com numeros em sequencia
            double salario = double.Parse(Console.ReadLine());
            somaSalarios += salario;
            //Vai guardar em somaSalarios todos os salarios iformados

            if (salario > maiorSalario) //Para pegar o maior salario
            {
                maiorSalario = salario; //Armazena o maior salario
            }

            Console.WriteLine($"Informe o número de filhos do habitante {i}: "); //Mesma coisa de habitantes
            int numFilhos = int.Parse(Console.ReadLine());
            //Converte e armazena
            somaFilhos += numFilhos;//Soma todos os filhos e armazena

            if (salario <= 100) //Salario <= 100
            {
                contadorSalarioAte100++; //Soma + 1 
            }
        }

        double mediaSalario = somaSalarios / th; //Calcula media
        double mediaFilhos = (double)somaFilhos / th;
        //Media filhos
        double percentualSalarioAte100 = (double)
        contadorSalarioAte100 / th * 100;
        //Percentual de salarios ate 100

        Console.WriteLine($"A média do salário da população é: {mediaSalario:C}");//Exibe a media salario 
        Console.WriteLine($"A média do número de filhos é: {mediaFilhos:F}"); // Exibe media dos filhos
        Console.WriteLine($"O maior salário é: {maiorSalario:C}");//Exibe o maior salario
        Console.WriteLine($"O percentual de pessoas com salário até R$100,00 é: {percentualSalarioAte100:F}%"); // Exibe o percentual de salarios ate 100
    }
}
