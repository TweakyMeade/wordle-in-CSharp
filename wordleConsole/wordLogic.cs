using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace wordleConsole
{
    internal class wordLogic
    {


        public List<string> wordsArray = new List<string>();
        public string word;
        public List<string> letterList; 
        private sharedFuncs sharedFuncs = new sharedFuncs();
        private Random random = new Random();
        
        public wordLogic()
        {
            using (StreamReader text = new StreamReader("words.txt"))
            {
                foreach (string line in text.ReadToEnd().Split()) { wordsArray.Add(line.ToUpper()); }
            }
            word = wordsArray[random.Next(0, wordsArray.Count-1 )].ToUpper();
            letterList = sharedFuncs.charArrayToStringList(word);

        }
    }
}
