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
        public string NotNullInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            while (input == null)
            {
                Console.WriteLine("input cannot be null");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
