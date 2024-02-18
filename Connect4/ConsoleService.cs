using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Connect4
{
    internal class ConsoleService
    {
        public string NotEmptyInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (input == "")
            {
                Console.WriteLine("input cannot be empty");
                input = Console.ReadLine();
                input = input.Trim();
            }
            return input;
        }
    }
}
