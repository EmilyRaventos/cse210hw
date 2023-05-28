using System;
using ProgramSpace;
using ScriptureSpace;

namespace WordSpace
{
    public class Word
    {
        private string _word;
        private bool _hidden;

        public Word(string word)
        {
            _word = word;
        }

        public void Hide()
        { 
            _hidden = true;
        }

        public void Show()
        {
            _hidden = false;
        }

        public bool IsHidden()
        {
            return _hidden;
        }

        public string GetRenderedText()
        {
            if (_hidden == false)
            {
                return _word;
            }

            else
            {
                string hiddenWord = "";
                foreach (char letter in _word)
                {
                    hiddenWord += "_";
                }

                return hiddenWord;
            }
        }
    }
}