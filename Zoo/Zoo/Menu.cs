using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Menu
    {
        /// <summary>
        /// Outputs given string with a color
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="color"></param>
        public void Print(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public void Start()
        {
            Print("Welcome." + "\n" + "Please input the feature you wish to use", ConsoleColor.Yellow);
            Print("1. List all animals in the zoo", ConsoleColor.Yellow);
            Print("2. List all animals by type", ConsoleColor.Yellow);
            Print("3. List all animals by name", ConsoleColor.Yellow);
        }





    }
}
