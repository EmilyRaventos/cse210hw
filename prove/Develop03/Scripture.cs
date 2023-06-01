using System;
using Program1;
using References;
using Words;

namespace Scriptures
{
    public class Scripture
    {
        private string _reference;
        private string _scriptureText;
        private List<Word> _listOfWords;
        private bool _completelyHidden;
        private List<int> _listOfIndex;
        private int _numberOfHidden = 0;

        public Scripture(Reference reference, string scriptureText)
        {  
            _reference = reference.GetReferenceString();
            _scriptureText = scriptureText;

            List<Word> listOfWords = new List<Word>();

            string[] HideWords = _scriptureText.Split(" ");

            foreach (string word in HideWords)
            {
                Word newWord = new Word(word);
                newWord.Show();

                listOfWords.Add(newWord);
            }

            _listOfWords = listOfWords;

            List<int> listOfIndex = new List<int>();
            _listOfIndex = listOfIndex;
        }

        public void HideWords()
        {
            int randomIndex = GetRandomIndex();

            // Only hide words once
            while (_listOfIndex.Contains(randomIndex))
            {
                randomIndex = GetRandomIndex();
            }
            _listOfIndex.Add(randomIndex);
            _listOfWords[randomIndex].Hide();
        }

        public string GetRenderedText()
        {
            string renderedText = _reference + " ";

            foreach (Word word in _listOfWords)
            {
                renderedText += word.GetRenderedText() + " ";
            }
            return renderedText;
        }

        private int GetRandomIndex()
        {
            Random random = new Random();
            return random.Next(0, _listOfWords.Count());
        }

        public bool IsCompletelyHidden()
        {
            if (GetWordCount() < _listOfIndex.Count)
            {
                return _completelyHidden;
            }
            // foreach (Word word in _listOfWords)
            // {
            //     if (word.IsHidden() == false)
            //     {
            //         _completelyHidden = false;
            //     }
            //     else
            //     {
            //         _completelyHidden = true;
            //     }
            // }
            _completelyHidden = false;

            return _completelyHidden;
        }

        public int GetWordCount()
        {
            return _listOfWords.Count();
        }

    }
}