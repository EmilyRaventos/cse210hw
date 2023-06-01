using System;
using Program1;
using Scriptures;

namespace References
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _endVerse = "";
        private string _reference;

        public Reference(string book, string chapter, string verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public Reference(string book, string chapter, string verse, string endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }

        public string GetReferenceString()
        {
            if (_endVerse == "")
            {
                _reference = $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }

            return _reference;
        }
    }
}
