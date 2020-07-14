using System;

namespace Connect4
{
    class Program
    {
        private const string V = "";
        private static readonly string EOL = Environment.NewLine;

        private static readonly ConsoleService consoleService = new ConsoleService();
 
        private static readonly string[] yesOptions = { "y", "yes" };

        private static readonly string[] noOptions = { "n", "no" };

        private static bool isP1 = true;

        private static bool gameOver = false;

        private static bool stalemate = false;

        private static bool playAgain = true;

        private static string player1 = "Player 1";

        private static string player2 = "Player 2";

        private static string winnerShape = "";

        private static string playAgainAnswer = string.Empty;

        private static int player1Score = 0;

        private static int player2Score = 0;

        private static int stalemateCount = 0;
    
        static void Main()
        {
            Game game = new Game();

            consoleService.PrintGame(game);
            Console.ReadKey();
        }
    }
}
