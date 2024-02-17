using System;

class Program
{
    public static void Main(string[] args)
    {
        int cont = 1;
        double triplo, n1;
        while (cont <= 3)
        {
            Console.WriteLine("Digite o valor para ser multplicado por 3: ");
            n1 = double.Parse(Console.ReadLine());
            triplo = n1 * 3;
            Console.WriteLine("O resultado é " + triplo);
            cont++;
        }
    }
}
