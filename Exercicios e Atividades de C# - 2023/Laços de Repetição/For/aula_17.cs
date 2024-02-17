using System;

namespace aula_30_forMult4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 10;

            Console.WriteLine("Digite 10 números:");

            for (int i = 0; i < totalNumeros; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 4 == 0)
                {
                    Console.WriteLine(numero + " é múltiplo de 4.");
                }
            }
        }

}
    
}
