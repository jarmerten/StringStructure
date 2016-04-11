using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            SortedList<int, ICustomString> containsStringsWithChanges = new SortedList<int, ICustomString>();
            string secondString = "bkoooolm";
            string test1string = "Jared";
            string test2string = "Jared-"; 
            string test3string = "Jared--";
            string test4string = "Jared---";


            SystemArrayString testSystemArrayString = new SystemArrayString(test2string);
            SystemLinkedListString testSystemLinkedListString = new SystemLinkedListString(test3string);
            SystemString testSystemString = new SystemString(test1string);
            CustomLinkedListString testCustomLinkedListString = new CustomLinkedListString(test4string);
            containsStringsWithChanges.Add(containsStringsWithChanges.Count, testSystemString);
            containsStringsWithChanges.Add(containsStringsWithChanges.Count, testSystemArrayString);
            containsStringsWithChanges.Add(containsStringsWithChanges.Count, testSystemLinkedListString);
            containsStringsWithChanges.Add(containsStringsWithChanges.Count, testCustomLinkedListString);

            foreach (ICustomString cycletrhoughclasses in containsStringsWithChanges.Values)
            {
                cycletrhoughclasses.Insert(2,secondString);
                cycletrhoughclasses.Remove(4,4);
                cycletrhoughclasses.Length();
                cycletrhoughclasses.ToString();
            }
            Console.ReadLine();


        }
    }
}
