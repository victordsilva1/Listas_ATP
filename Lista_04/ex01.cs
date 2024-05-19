class Program
{

    static void Medias(double note1, double note2, double note3, char escolha)
    {

        double media = (note1 + note2 + note3) / 3;
        double mediaP = (note1 * 5 + note2 * 3 + note3 * 2) / 10;
        if (escolha == 'A')
        {
            Console.WriteLine("A media das notas = " + media);
        }
        else if (escolha == 'P')
        {
            Console.WriteLine("A média Ponnderada das notas = " + mediaP);
        }

        else
        {
            Console.WriteLine("Numero/Letra Inválido");
        }

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Número de Alunos: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n ; i++)
            {
            
                Console.WriteLine(i+1+" Aluno");

            Console.WriteLine("Digite o nome do aluno: ");
            string alun = Console.ReadLine();
            
            Console.WriteLine("1 Nota: ");
            double note1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 Nota: ");
            double note2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3 Nota: ");
            double note3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deseja calcular a (média digite 'A') e (média Ponderada 'P'): ");
            char escolha = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("aluno "+ alun +" notas :");
            Medias(note1,note2,note3,escolha);
            


            }
        }
    }
