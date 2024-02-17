using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] produto = new string[15];
        double[] valor = new double[15];
        double soma;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Digite o nome do " + i + "º produto: ");
            valor[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 20; i++)
        {
            soma = valor[i] + valor[i];
        }
    }
}
