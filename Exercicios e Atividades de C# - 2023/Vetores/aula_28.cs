using System;

namespace aula08_vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letras = new string[5];
            int vogalCount = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite uma letra:");
                letras[i] = Console.ReadLine().ToLower(); // Armazenar letras em minúsculas

                switch (letras[i])
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("VOGAL\n");
                        vogalCount++;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("CONSOANTE\n");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (vogalCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nAs vogais digitadas foram:");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < 5; i++)
                {
                    if (letras[i] == "a" || letras[i] == "e" || letras[i] == "i" || letras[i] == "o" || letras[i] == "u")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("- " + letras[i]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNenhuma vogal foi digitada.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
