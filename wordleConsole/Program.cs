using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            wordSubject subject = new wordSubject();
            gameLogic round = new gameLogic("test1", "jets1");
            Console.WriteLine(round.winCondition);
            Console.WriteLine(round.correctPlacement);
            Console.WriteLine("wrong placement:");
            charPrint(round.wrongPlacement());
            Console.WriteLine("wrong letter:");
            charPrint(round.wrongLetter());

        }
        static void charPrint(List<char> x) { foreach (char i in x) { Console.Write(i.ToString());  } Console.Write("\n"); }
    }
}
