using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class consoleRender
    {
        private gameLogic game;
        private int count = 0;
        public consoleRender(gameLogic g)
        {
            game = g;
        }
        private void border() { for (int i = 0; i < 10; i++) { Console.Write("+_"); } Console.Write("+"); Console.Write("\n"); }
        private void board()
        {
            foreach (string a in game.bilboardHistory)
            {
                Console.WriteLine(a);
            }
        }
        private void input() 
        {
            Console.Write("\nGuess:");
            game.inputWord();
        }

        public void render(bool debug)
        {
            count++;
            Console.Clear();
            if (debug) { Console.WriteLine($"Debug: {game.trueWord()}"); }
            border();
            board();
            border();
            input();
        }
        public void end()
        {
            Console.Clear();
            border();
            board();
            border();
            if (game.win){ Console.WriteLine($"You got {game.trueWord()} in {count} rounds "); }
            else { Console.WriteLine($"You lost, the Awnser was {game.trueWord()}"); }
        }
     }    
    
}
