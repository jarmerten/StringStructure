using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class SystemString : ICustomString
    {
        string customword;
                public SystemString()
            {
            }
            public SystemString(string customWord)
            {
            customword = customWord;
            }
                public override string ToString()
                {
                    return customword.ToString();
                }
                public void Insert(int startIndex, string stringToInsert)
                {
                    string end = customword.Substring(startIndex);
                    string beginning = customword.Substring(0, startIndex);
                    customword = beginning + stringToInsert + end;
                }
                public void Remove(int startIndex, int numCharsToRemove)
                {
                    customword = customword.Remove(startIndex, numCharsToRemove);
                }
                public int Length()
                {
                    return customword.Count();
                }
    }
}
        //            Underlying structure: System.string
        //       Piggyback off System.string's built-in functionality to implement ICustomString's functions

