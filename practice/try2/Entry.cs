// using System;
// using Program;

// namespace Entry {
//     public class Entry
//     {
//         // public int _journalNumber;
//         public string _date;
//         public string _prompt;
//         public string _response;
//         string _entry;
//         List<string> entries = new List<string>{};

//         public string CreateEntry(string prompt, string response) 
//             {
//                 DateTime theCurrentTime = DateTime.Now;
//                 _date = theCurrentTime.ToShortDateString();
//                 _entry = $"Date: {_date} ~ Prompt: {prompt}\n{response}\n";
//                 entries.Add(_entry);
//                 return _entry;
//             }
//     }
// }