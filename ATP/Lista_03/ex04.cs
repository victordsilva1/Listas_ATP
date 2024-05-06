Console.WriteLine("Calculadora fatorial (!)");

//Pede o user para digitar um valor
Console.WriteLine("Escreva um número e veja seu fatorial: ");
    int num = Convert.ToInt32(Console.ReadLine());
    //CONVERTE E ARMAZENA
if(num< 0) 
{
    Console.WriteLine("Não é possivel calcular fatoraial de negativos");//Exibe a mensagem se o num > 0 
    return;//Retorna
}
if(num == 0) //Se for num==0 
{
    Console.WriteLine("Fatorial = 1"); //Exibe fatorial = 1
}
    else { //Caso  não

        int fato = 1; //fato inicia com 1

        for (int v = 1; v<=num ;v++) //v inicia com 1, 1 tem que ir ate o numero que o user escolheu , soma v + 1 para nao dar loop
        {
            fato *= v; //Ex se for 4: ,fato inicia com 1; 
            //fato = fato*2= 2 (;) fato = fato*3 (;) fato = fato*4
            //fim do codigo porque v=num 4=4
            
        }
         Console.WriteLine("O fatorial de " + num + " é: " + fato);
         //Exibe o valor digitado e o valor da var fato que no caso do ex é 24 
    }
