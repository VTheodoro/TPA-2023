using System;

class Program
{
    public static void Main(string[] args)
    {
        int nasc, idade;
        int cont = 1;
        while (cont <= 4)
        {
            Console.WriteLine("Digite o ano de nascimento: ");
            nasc = int.Parse(Console.ReadLine());
            idade = 2023 - nasc;
            Console.WriteLine("Sua idade é " + idade + " anos!");
            cont++;
        }
    }
}
