class Program
{

    static void Medias(double note1, double note2, double note3, char escolha)
    {
            //Declarado as variables 
        double media = (note1 + note2 + note3) / 3; //Media
        double mediaP = (note1 * 5 + note2 * 3 + note3 * 2) / 10; //Media Ponde
        if (escolha == 'A')  //Se a escolha for A 
        {
            Console.WriteLine("A media das notas = " + media); //Sera exibido a media 
        }
        else if (escolha == 'P')
        {
            Console.WriteLine("A média Ponnderada das notas = " + mediaP); //Se for P sera exibido a media Ponderada
        }

        else
        {
            Console.WriteLine("Numero/Letra Inválido");
        } //Caso nada disso seja feito Exibe isso.

    }

    static void Main(string[] args) //1
    {
        Console.WriteLine("Número de Alunos: "); //Pede o numero de alunos 
        int n = Convert.ToInt32(Console.ReadLine()); //COnverte para Int

        for (int i = 0; i < n ; i++) //For que vai ate o numero de alunos ser atingido
            {
            
                Console.WriteLine(i+1+" Aluno"); //Mostrar qual aluno esta

            Console.WriteLine("Digite o nome do aluno: "); //Digitar o nome 
            string alun = Console.ReadLine(); //Armazena 
            
            Console.WriteLine("1 Nota: ");  //Notas e armazena em variables 
            double note1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2 Nota: ");
            double note2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3 Nota: ");
            double note3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deseja calcular a (média digite 'A') e (média Ponderada 'P'): ");
            char escolha = Convert.ToChar(Console.ReadLine().ToUpper()); //Armazena na char escolha, o ToUpper serve poara evitar erros 'a' e 'p'

            Console.WriteLine("aluno "+ alun +" notas :"); //Mostra ao final nome do aluno

            Medias(note1,note2,note3,escolha); //Mostar a media de acorddo com a escolha 
            


            }
        }
    }
