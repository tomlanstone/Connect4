using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    public class ConsoleService
    {
        private static readonly string EOL = Environment.NewLine;
        private readonly string[] yesValues = new string[] { "y", "yes", "true", "1" };

        public ConsoleService()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

        }

        public void PrintLine(string line = "", ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            Print(line, foregroundColor, backgroundColor);
            Console.WriteLine();
        }

        public void Print(string line = "", ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            ConsoleColor previousForegroundColor = Console.ForegroundColor;
            if (foregroundColor != null)
            {
                Console.ForegroundColor = (ConsoleColor)foregroundColor;
            }

            ConsoleColor previousBackgroundColor = Console.BackgroundColor;
            if (backgroundColor != null)
            {
                Console.BackgroundColor = (ConsoleColor)backgroundColor;
            }

            Console.Write(line);

            Console.ForegroundColor = previousForegroundColor;
            Console.BackgroundColor = previousBackgroundColor;
        }

        public string AskQuestion(string question, string errorMessage = "")
        {
            Print(EOL + errorMessage + EOL + EOL + question + EOL + "--> ");
            return Console.ReadLine();
        }

        public bool AskYesNo(string question)
        {
            string answer = AskQuestion(question);
            return yesValues.Contains(answer.ToLower());
        }

        public void SetBackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void ResetConsoleColors()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            ClearScreen();
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public void PrintPlayerColor(string value, Player player)
        {
            if (player == Player.One)
            {
                Print(value, ConsoleColor.Blue);
                return;
            }

            Print(value, ConsoleColor.Red);
        }

        public void PrintGame(Game game)
        {
            for (int i = 0; i < game.boardHeight; i++)
            {
                PrintRowDivider(game);
                PrintRow(game, i);
            }
            PrintRowDivider(game);
            for (int i = 0; i < game.boardLength; i++)
            {
                Print("  " + (char)(65+i) + " ");
            }
        }

        private void PrintRow(Game game, int rowNumber)
        {
            for (int i = 0; i < game.boardLength; i++)
            {
                Print("ǀ");
                Print("   ");
            }
            PrintLine("ǀ");
        }

        private void PrintRowDivider(Game game)
        {
            for (int i = 0; i < 4 * game.boardLength + 1; i++)
            {
                Print("-");
            }
            PrintLine();
        }
    }

}
