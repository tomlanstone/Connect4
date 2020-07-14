using System;
using System.Collections.Generic;
using System.Text;

namespace Connect4
{
    public class Game
    {
        public readonly int boardLength;

        public readonly int boardHeight;

        private readonly int winLength;

        private readonly int[][] board;
        public Game(int boardLength = 7, int boardHeight = 6, int winLength = 4)
        {
            this.boardLength = boardLength;

            this.boardHeight = boardHeight;

            this.winLength = winLength;

            board = new int[boardLength][];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new int[boardHeight];
            }

        }


    }


}
