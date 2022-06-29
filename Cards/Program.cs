using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string userOption = UserOptions();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    // case "1":
                    //     ShowtAllCards();
                    //     break;

                    // case "2":
                    //     ShowDiamonds();
                    //     break;

                    // case "3":
                    //     ShowSpades();
                    //     break;

                    // case "4":
                    //     ShowHearts();
                    //     break;

                    // case "5":
                    //     ShowClubs();
                    //     break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = UserOptions();
            }
            Console.WriteLine("Aperte uma tecla para sair!");
            Console.ReadKey();
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
        public static void DrawColumns(string symbol, string space, int value)
        {
            Console.Write(symbol);
            for (int columns = 0; columns <= value; columns++)
                Console.Write(space);
            Console.Write(symbol);
            Console.Write("\n");
        }
        public static void DrawLines()
        {
            for (int lines = 0; lines < 1; lines++)
                DrawColumns("|", " ", 36);
        }
    }
}
