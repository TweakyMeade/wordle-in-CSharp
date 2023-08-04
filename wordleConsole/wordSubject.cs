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
        private string chosenWord;
        private List<string> chosenArray =new List<string>();

        public wordSubject()
        {
            chosenWord = wordsArray[0];
        }

        public string roundWord() 
        { 
            return chosenWord; 
        }
        
        public List<string> letterArray() 
        {
            foreach (char i in chosenWord.ToCharArray())
            {
                chosenArray.Add(i.ToString());
            }
            return chosenArray;
        }
    }
}
