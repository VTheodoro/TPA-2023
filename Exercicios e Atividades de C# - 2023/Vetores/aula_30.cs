using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] n1 = new int[20];
        double resto;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Digite um valor: ");
            n1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 20; i++)
        {
            resto = n1[i] % 5;
            if (resto == 0)
            {
                Console.WriteLine(n1[i] + " é um número múltiplo de 5!");
            }
        }
    }
}
