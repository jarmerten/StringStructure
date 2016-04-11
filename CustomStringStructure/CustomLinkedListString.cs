using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure 
{
     public class CustomLinkedListString : ICustomString
    {
        public Node header;
        public Node last;
        public string customWord;
        int howManyNodes = 0;
        public CustomLinkedListString()
        {
        }
        public CustomLinkedListString(string customword)
        {
            customWord = customword;
            foreach (char character in customWord)
            {
                Add(character);
            }
        }
                public void Add(char addAChar)
                {
                        howManyNodes++;
                        Node n = new Node();
                        n.Value = addAChar;
                        n.Next = null;
                        if (last == null)
                        {
                            header = n;
                            last = n;
                        }
                        else
                        {
                            last.Next = n;
                            last = n;
                        }
                }
            public Node Find(int startLocation)
            {
                Node Current = new Node();
                Current = header;
                for (int i = 1; i < startLocation; i++)
                {
                    Current = Current.Next;
                }
                return Current;
            }
            public override string ToString()
                {
                string customListToStringWord = null;
                Node Current = new Node();
                Current = header;
                for(int i=0; i<howManyNodes; i++)
                {
                 customListToStringWord += Current.Value.ToString();         
                 Current = Current.Next;
                }
                return customListToStringWord;
                }
                public void Insert(int startIndex, string stringToInsert)
                {
                        int spotToPutNewNode = 1;
                        Node current = new Node();
                        startIndex -= 2;
                    foreach (char character in stringToInsert)
                    {
                        howManyNodes++;    
                        Node newNode = new Node(character);
                            if (current.Value == null)
                            {
                                current = Find(startIndex + 1);
                            }
                            else
                            {
                                spotToPutNewNode++;
                                current = Find(startIndex + spotToPutNewNode);
                            }
                        newNode.Next = current.Next;
                        current.Next = newNode;
                    }
                }
                public void Remove(int startIndex, int numCharsToRemove)
                {
                    startIndex -= 2;
                    Node current = new Node();
                    Node replaceingNode = new Node();
                        for(int i = 0; i < howManyNodes; i++)
                        {
                            if (i == 0)
                            {
                                current = Find(startIndex+1);
                                replaceingNode = Find(startIndex + numCharsToRemove +1);
                            }
                            if (startIndex==-1)
                            {
                                header = replaceingNode.Next;
                            }
                                 current.Next = replaceingNode.Next;
                      }
                    howManyNodes -= numCharsToRemove;
                }
                public int Length()
                {
                    return howManyNodes;
                }


        //            Underlying structure: your own custom linked list
        //Each node of the underlying custom linked list structure holds one character
    }
}
