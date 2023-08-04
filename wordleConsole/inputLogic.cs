using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{

    internal class inputLogic
    {
        public string word { get; }
        public List<string> letterList { get; }
        private sharedFuncs sharedFuncs;
        public inputLogic(string _inputWord)
        {
            word = _inputWord.ToUpper();

            letterList = sharedFuncs.charArrayToStringList(word.ToCharArray());
        }
    }
}
