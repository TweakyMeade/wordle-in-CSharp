using System.Collections.Generic;
using System.Linq;

namespace wordleConsole
{
    internal class gameLogic
    {

        private inputLogic guess;
        private wordLogic awnser;

        private List<string> correctLettersUsed = new List<string>();
        private List<string> wrongLettersUsed = new List<string>();
        private List<string> wrongWords = new List<string>();
        public string correctPlacement { get; }
        public bool winCondition { get; }
        public bool notAlreadyUsed { get; }
        private sharedFuncs sharedFuncs;

        public gameLogic(inputLogic _guess, wordLogic _awnser) 
        {
            guess = _guess;
            awnser = _awnser;


           winCondition = true;
           
        }

         private string correctPlacementCheccker(string inputWord)
        {
            string correctPlacementOutput = "";
            for (int i = 0; i< guess.letterList.Count; i++)
            {
                if (guess.letterList[i] == awnser.letterList[i]) { correctPlacementOutput += guess.letterList[i]; }
                else if (awnser.letterList.Contains(guess.letterList[i])) { correctLettersUsed.Add(guess.letterList[i]); wrongWords.Add(awnser.word); correctPlacementOutput += "0"; }
                else { wrongLettersUsed.Add(guess.letterList[i]); wrongWords.Add(awnser.word); correctPlacementOutput += "_"; }
            }

            return correctPlacementOutput;
        }

        public bool win(string inputWin)
        {
            return string.Equals(inputWin, trueWord);
        }
        public bool notAlreadyUsedFunc()
        { 
            if (wrongWords.Contains()) { return true; }
            else { return false; }
        }
        public List<string> wrongPlacement() { return correctLettersUsed; }
        public List<string> wrongLetter() { return wrongLettersUsed; }




    }
}
