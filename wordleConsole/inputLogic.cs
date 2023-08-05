using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{

    internal class inputLogic
    {
        public string word;
        public List<string> usedWords = new List<string>();


        private sharedFuncs sharedFuncs = new sharedFuncs();


       public List<string> letterList()
       { 
           return sharedFuncs.charArrayToStringList(word); 
       }
    }
}
