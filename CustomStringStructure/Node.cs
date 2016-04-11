using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class Node
    {
        public char? Value;
        public Node Next = null;
        public Node()
        {
            Value = null;
            Next = null;
        }
    public Node(char TheElement)
        {
            Value = TheElement;
            Next = null;
        }
    }
}
