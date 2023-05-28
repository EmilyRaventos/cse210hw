using System;
using ScriptureSpace;
using ProgramSpace;

namespace ReferenceSpace
{
    public class Reference
    {
        private string _book;
        private string _chapter;
        private string _verse;
        private string _endVerse;

        // Constructor
        public Reference(string book, string chapterNumber, string verseNumber)
        {
            _book = book;
            _chapter = chapterNumber;
            _verse = verseNumber;
        }

        // Constructor for scripture with multiple verses
        public Reference(string book, string chapterNumber, string verseNumber, string endVerse)
        {
            _book = book;
            _chapter = chapterNumber;
            _verse = verseNumber;
            _endVerse = endVerse;
        }

        public string GetReferenceString()
        {
            string reference = "";

            // Get reference for single verse scripture.
            if (_endVerse == null)
            {
                reference = $"{_book} {_chapter}:{_verse}";
            }

            // Get reference for multiple verse scripture.
            else
            {
                reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }

            return reference;
        }
    }
}