using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class SystemLinkedListString : ICustomString
    {
        LinkedList<char> SeperateWordsIntoChars = new LinkedList<char>();
            string customword;
            string secondWord;
            string wholeWord;
            public SystemLinkedListString(string customWord)
        {
            customword = customWord;
            foreach(char letter in customWord)
            {
                SeperateWordsIntoChars.AddLast(letter);
            }
        }
        public override string ToString()
        {
            string charToAdd = null;
            for (int i = 0; i < SeperateWordsIntoChars.Count; i++)
            {
                charToAdd += SeperateWordsIntoChars.ElementAt(i).ToString();
            }
            return charToAdd;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            int i = 0;
            secondWord = stringToInsert;
            LinkedList<char> AddTwoWordsToOneLinkedList = new LinkedList<char>();
            foreach (char letter in customword)
            {
                wholeWord += letter.ToString();
                AddTwoWordsToOneLinkedList.AddLast(letter);
                i++;
                    if (i == startIndex)
                        {
                            foreach (char letters in stringToInsert)
                            {
                            wholeWord += letters.ToString();
                            AddTwoWordsToOneLinkedList.AddLast(letters);
                            }
                        }
            }
            SeperateWordsIntoChars = AddTwoWordsToOneLinkedList;
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            int i = 0;
            LinkedList<char> AddTwoWordsToOneLinkedList = new LinkedList<char>();
                    foreach (char letter in wholeWord)
                    {
                     i++;
                        if (i <= startIndex || i > startIndex + numCharsToRemove)
                        {
                            
                            AddTwoWordsToOneLinkedList.AddLast(letter);
                        }
                    } 
            SeperateWordsIntoChars= AddTwoWordsToOneLinkedList;
        }
        public int Length()
        {
            return SeperateWordsIntoChars.Count;
        }
    }

        //                                 Underlying structure: System.Collections.Generic.LinkedList
        //   Each node of the underlying C# LinkedList holds one character
    
}
