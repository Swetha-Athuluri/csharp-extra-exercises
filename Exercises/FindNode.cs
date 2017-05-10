using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        CHALLENGE: Write the algorithm to find and return the given node based on its value, n. 
        If the node cannot be found, return null.

        */
        public LinkedListNode<int> FindNode(LinkedList<int> nodes, int n)
        {
            LinkedListNode<int> temp = nodes.First;
            while(temp.Next!=null)
            {
                if (temp.Value == n)
                    return temp;
                temp = temp.Next;
            }
            if (temp.Value == n)
                return temp;
            else return null;
        }
    }
}
