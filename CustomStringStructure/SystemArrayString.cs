using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class SystemArrayString : ICustomString
    {
        string combinetwowords;
        char[] SeperateWordsIntoChar;

            public SystemArrayString(string customWord)
            {
               combinetwowords = customWord;
               SeperateWordsIntoChar = customWord.ToCharArray();
            }
                public override string ToString()
                {
                    char charToAdd;
                    string combineCharForWord = null;
                    for (int i = 0; i < SeperateWordsIntoChar.Length; i++)
                    {
                        charToAdd = SeperateWordsIntoChar.ElementAt(i);
                        combineCharForWord += charToAdd.ToString();
                    }
                    return combineCharForWord;
                }
                public void Insert(int startIndex, string stringToInsert)
                {
                    int i = 0;
                    int arraySize = 0;
                    string total = stringToInsert + combinetwowords;
                    foreach(char character in total)
                    {
                        arraySize++;
                    }
                    char[] TemporaryStoryWordsCombinedChar = new char[arraySize];
                    while(i < startIndex)
                    {
                        TemporaryStoryWordsCombinedChar[i] = SeperateWordsIntoChar.ElementAt<char>(i);
                        i++;
                    }
                        int secondwordcounter = i;
                        foreach(char letter in stringToInsert)
                    {
                        TemporaryStoryWordsCombinedChar[secondwordcounter] = letter;
                        secondwordcounter++;
                    }
                    while(secondwordcounter<arraySize)
                    {
                        TemporaryStoryWordsCombinedChar[secondwordcounter] = SeperateWordsIntoChar.ElementAt<char>(i);
                        secondwordcounter++;
                        i++;
                    }
                    SeperateWordsIntoChar = TemporaryStoryWordsCombinedChar;
                }
                public void Remove(int startIndex, int numCharsToRemove)
                {
                    int totalOfArrayAfterRemoval = SeperateWordsIntoChar.Count()-(numCharsToRemove);
                    char[] TemporaryStoryWordsCombinedChar = new char[totalOfArrayAfterRemoval];
                    int addElementHere = 0;
                    int largestRemoval = startIndex + numCharsToRemove;
                    for(int i = 0; i<SeperateWordsIntoChar.Count(); i++)
                    {
                        if ((i < startIndex)  || (i >= largestRemoval))
                        {
                            TemporaryStoryWordsCombinedChar[addElementHere] = SeperateWordsIntoChar.ElementAt<char>(i);
                            addElementHere++;
                        }
                    }
                    SeperateWordsIntoChar = TemporaryStoryWordsCombinedChar;
                }
                public int Length()
                {
                    return SeperateWordsIntoChar.Length;
                }
    }
}
        //            Underlying structure: System.array
        //  Each index of the underlying array holds one character
