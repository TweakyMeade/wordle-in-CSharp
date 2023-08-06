using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            wordLogic wordLogic = new wordLogic();
            inputLogic inputLogic = new inputLogic();
            game game = new game(inputLogic, wordLogic);
            consoleRender consoleRender = new consoleRender(game);
            int count = 1;
            for (int i= 0; i<7; i++)
            {
                consoleRender.render();
                if (game.win) { break; };
                count++;
            }

        }
    }
}