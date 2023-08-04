using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class gameLogic
    {
        private string inputWord;
        private char[] inputCharArray;
        private string trueWord;
        private char[] trueCharArray;
        private List<char> correctLettersUsed = new List<char>();
        private List<char> wrongLettersUsed = new List<char>();
        public string correctPlacement { get; }
        public bool winCondition { get; }



        public gameLogic(string _inputWord,string _trueWord) 
        {
            string inputWord = _inputWord.ToUpper();
            string trueWord = _trueWord.ToUpper();
            inputCharArray = inputWord.ToCharArray();
            trueCharArray= trueWord.ToCharArray();
            correctPlacement = correctPlacementCheccker();
            winCondition = string.Equals(inputWord, trueWord);
            
        }

         private string correctPlacementCheccker()
        {
            string correctPlacementOutput = "";
            for (int i = 0; i< trueCharArray.Length; i++)
            {
                if (inputCharArray[i] == trueCharArray[i]) { correctPlacementOutput += trueCharArray[i].ToString(); }
                else if (trueCharArray.Contains(inputCharArray[i])) { correctLettersUsed.Add(inputCharArray[i]); correctPlacementOutput += "_"; }
                else { wrongLettersUsed.Add(inputCharArray[i]);  correctPlacementOutput += "_"; }
            }

            return correctPlacementOutput;
        }

        public List<char> wrongPlacement() { return correctLettersUsed; }
        public List<char> wrongLetter() { return wrongLettersUsed; }




    }
}
