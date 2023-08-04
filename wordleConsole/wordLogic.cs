using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class wordLogic
    {


        private string[] wordsArray = new string[] { "Test!" };
        public string word { get; }
        public List<string> letterList { get; }
        private sharedFuncs sharedFuncs;

        public wordLogic()
        {
            word = wordsArray[0];
            letterList = sharedFuncs.charArrayToStringList(word.ToCharArray());

        }
    }
}
