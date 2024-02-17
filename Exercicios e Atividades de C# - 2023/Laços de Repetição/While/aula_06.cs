using System;

namespace aula_04_mult
{
    class Program
    {
        static void Main(string[] args)
        {

            double num, result;
                int cont = 3;

            while (cont > 0)
            {

                Console.WriteLine("Você tem " + cont + " multiplicações para realizar \nDigite um numero");
                num = double.Parse(Console.ReadLine());

                result = num * 4;

                cont--;

                Console.WriteLine("O resultado da sua muiltiplicação é "+result);
                Console.WriteLine("---------------------------------------------------------------");

            }



        }
    }
}
