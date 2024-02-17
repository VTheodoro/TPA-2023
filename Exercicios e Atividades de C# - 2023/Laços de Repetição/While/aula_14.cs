using System;

namespace aula_05_nasc
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 5;
            int idade, anoat, anonc;

            while(cont > 0)
            {

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Você tem "+cont+" calculos de idade para fazer.");
                Console.WriteLine("Digite o ano de nascimento da pessoa escolhida: ");
                anonc = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ano atual: ");
                anoat = int.Parse(Console.ReadLine());
    }
}
