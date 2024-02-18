using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    internal class Player
    {
        private int player_num;
        private string colour;
        private string name;

    public Player(int player_num, string colour, ConsoleService Interactor)
        {
            this.player_num = player_num; 
            this.colour = colour;
            this.name = Interactor.NotNullInput("Enter player name:");
        }
    public int PlayerNum { get { return player_num; } }
    public string Colour {  get { return colour; } }
    public string PlayerName { get { return name; } }
    }
}

