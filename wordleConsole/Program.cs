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

            Console.WriteLine(subject.letterArray().ToString());
            ;
        }
    }
}
