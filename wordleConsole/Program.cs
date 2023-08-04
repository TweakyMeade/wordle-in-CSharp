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
            wordLogic subject = new wordLogic();

            gameLogic round = new wordLogic("test1", "test1");
            Console.WriteLine(round.winCondition);
            Console.WriteLine(round.correctPlacement);
            Console.WriteLine("wrong placement:");
            charPrint(round.wrongPlacement());
            Console.WriteLine("wrong letter:");
            charPrint(round.wrongLetter());
            Console.WriteLine($"Not Equil:{round.winCondition}");

        }
        static void charPrint(List<string> x) 
        { 
            Console.WriteLine(x.Count); 
            foreach (string i in x) { Console.Write(i.ToString());  } 
            Console.Write("\n"); 
        }
    }
}
