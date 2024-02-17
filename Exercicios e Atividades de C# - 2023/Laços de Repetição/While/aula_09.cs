using System;

namespace aula_08_pares1a500
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int resto;

            while (cont <= 500)
            {
                resto = cont % 2;

                if (resto == 0)
                {
                    Console.WriteLine("- "+cont);
                }

                cont++;

            }
        }
    }
}
