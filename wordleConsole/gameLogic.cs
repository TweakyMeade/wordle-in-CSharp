﻿using System;
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
        public List<string> bilboardHistory = new List<string>() { "_____" };

        public string correctPlacement;
        public bool win;
        public bool notAlreadyUsed;
        public string billBoard;


        public gameLogic(inputLogic _guess, wordLogic _awnser)
        {
            guess = _guess;
            awnser = _awnser;
        }

        private void correctPlacementCheccker()
        {
            string correctPlacementOutput = "";
            List<string> letterList = guess.letterList();

            for (int i = 0; i < letterList.Count; i++)
            {
                if (letterList[i] == awnser.letterList[i]) { correctPlacementOutput += "X"; }
                else if (awnser.letterList.Contains(letterList[i])) { correctLettersUsed.Add(letterList[i]); correctPlacementOutput += "0"; }
                else { wrongLettersUsed.Add(letterList[i]);  correctPlacementOutput += "_"; }
            }

            bilboardHistory.Add($"{guess.word}\n{correctPlacementOutput}");
            
        }


        public bool winCondition()
        {
             return string.Equals(guess.word, awnser.word);
        }
        public void inputWord()
        {
            while (true)
            {
                string inputT = Console.ReadLine().ToUpper();
                if (!guess.usedWords.Contains(inputT) && inputT.Length == 5 && awnser.wordsArray.Contains(inputT))
                {
                    guess.word = inputT;
                    correctPlacementCheccker();
                    guess.usedWords.Add(inputT);
                    win = winCondition();
                    break;
                }
                Console.WriteLine($"{inputT} is not valid: ");
                if (inputT.Length != 5) { Console.Write("Not 5 letters long!\n"); }
                else if (awnser.wordsArray.Contains(inputT)) {Console.Write("Used word before\n"); }
                else { Console.Write("Not a Word!\n"); }
            }
            
        }

        public string trueWord() { return awnser.word; }
    }
}

