using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class consoleRender
    {
        private game game;
        public consoleRender(game g)
        {
            game = g;
        }
        public void border() { for (int i = 0; i < 10; i++) { Console.Write("+_"); } Console.Write("+"); Console.Write("\n"); }
        public void board() 
        { 
           foreach (string a in game.bilboardHistory)
            {
                Console.WriteLine(a);
            }
        }
        public void input()
        {
            Console.WriteLine("\nGuess:");
            game.inputWord();
        }
        public void wrongWords() 
        { 
        //    try { foreach word in game.wr}
        }

    }
}
