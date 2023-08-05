using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class wordLogic
    {


        public List<string> wordsArray = new List<string> { "TEST!", "TEST2", "TEST3" };
        public string word;
        public List<string> letterList; 
        private sharedFuncs sharedFuncs = new sharedFuncs();

        public wordLogic()
        {
            word = wordsArray[0].ToUpper();
            letterList = sharedFuncs.charArrayToStringList(word);

        }
    }
}
