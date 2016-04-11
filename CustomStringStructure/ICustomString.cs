using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
   public interface ICustomString
    {
        string ToString();
        void Insert(int startIndex, string stringToInsert);
        void Remove(int startIndex, int numCharsToRemove);
        int Length();
    }
}
