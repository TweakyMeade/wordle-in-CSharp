using System.Collections.Generic;
using System.Linq;

namespace wordleConsole
{
    internal class gameLogic
    {

        private inputLogic guess;
        private wordLogic awnser;

        public List<string> correctLettersUsed { get; }
        public List<string> wrongLettersUsed { get; }
        public List<string> wrongWords { get; }
        public string correctPlacement { get; }
        public bool winCondition { get; }
        public bool notAlreadyUsed { get; }
        public string billBoard { get; }



        private sharedFuncs sharedFuncs;

        public gameLogic(inputLogic _guess, wordLogic _awnser) 
        {
            guess = _guess;
            awnser = _awnser;
            winCondition = win();
            notAlreadyUsed = notAlreadyUsedFunc();
            billBoard = correctPlacementCheccker();
        }

         private string correctPlacementCheccker()
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

        public bool win()
        {
            return string.Equals(guess.word, awnser.word);
        }
        public bool notAlreadyUsedFunc()
        { 
            if (wrongWords.Contains(guess.word)) { return true; }
            else { return false; }
        }




    }
}
