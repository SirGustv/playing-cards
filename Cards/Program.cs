using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            UserOptions();
        }

        private static string UserOptions()
        {
            Console.WriteLine("Vizualizador de cartas!!!\n------------------------------");
            Console.WriteLine("1 - Visualizar todas as cartas");
            Console.WriteLine("2 - Visualizar cartas de Ouros");
            Console.WriteLine("3 - Visualizar cartas de Espadas");
            Console.WriteLine("4 - Visualizar cartas de Copas");
            Console.WriteLine("5 - Visualizar cartas de Paus");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            Console.Write("Escolha uma das opções acima: ");

            string userOption = Console.ReadLine().ToUpper();
            return userOption;
        }
    }
}
