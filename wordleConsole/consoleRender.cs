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
        private int count = 0;
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
            game.inputWord();
        }
        public void wrongWords()
        {
            //    try { foreach word in game.wr}
        }
        public void render()
        {
            count++;
            Console.Clear();
            border();
            board();
            input();
        }
        public void end()
        {
            if (game.win){ Console.WriteLine($"You got {game.trueWord()} in {count} rounds "); }
            else { Console.WriteLine($"You lost, the Awnser was {game.trueWord()}"); }
            Console.Read();

        }
     }    
    
}
