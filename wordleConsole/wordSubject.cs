using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class wordSubject
    {


        private string[] wordsArray = new string[] { "Test!" };

        private string[] chosenArray;

        public string roundWord() { return wordsArray[0]; }
        
        public string[] letterArray() 
        {
            chosenArray = wordsArray[0].Split();
            return chosenArray;
        }

    }
}
