using System;
using ReferenceSpace;
using WordSpace;
using ProgramSpace;

namespace ScriptureSpace
{
    public class Scripture
    {
        private Reference _reference;
        private string _scriptureText;
        private List<Word> _listOfWords;
        private bool _completelyHidden = false;
        
        public Scripture(Reference reference, string scriptureText)
        {
            _reference = reference;
            _scriptureText = scriptureText;

            List<Word> listOfWords = new List<Word>();
            string [] words = _scriptureText.Split(" ");

            foreach (string word in words)
            {
                Word newWord = new Word(word);
                newWord.Show();

                listOfWords.Add(newWord);
            }

            _listOfWords = listOfWords;
        }

        public void HideWord(List<Word> _listOfWords)
        {
            // Generate a random index
            Random rnd = new Random();
            int _randomIndex = rnd.Next(0, _listOfWords.Count);  
        }

        public string GetRenderedText(List<Word> _listOfWords)
        {
            string reference = _reference.GetReferenceString();
            string renderedText = reference + " ";

            foreach (Word word in _listOfWords)
            {
                renderedText += word.GetRenderedText();
            }

            return renderedText;
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _listOfWords)
            {
                if (word.IsHidden() == false)
                {
                    _completelyHidden = false;
                }

                else
                {     
                    _completelyHidden = true;
                }
            }

            return _completelyHidden;
        }

    }
}