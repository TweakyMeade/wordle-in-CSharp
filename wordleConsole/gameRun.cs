using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal  class gameRun
    {
        private static wordLogic wordLogic = new wordLogic();
        private static inputLogic inputLogic = new inputLogic();
        private static gameLogic game = new gameLogic(inputLogic, wordLogic);
        private static consoleRender consoleRender = new consoleRender(game);

        public void run() 
        { 
            for (int i = 0; i < 6; i++) 
            {
                consoleRender.render(false);
                Console.WriteLine(game.win);
                if (game.winCondition()) { break; };
            }
            consoleRender.end();
        }
    }
}
