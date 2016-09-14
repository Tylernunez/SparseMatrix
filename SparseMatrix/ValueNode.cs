using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    class ValueNode : Node
    {
        private int row;
        private int column;
        private int value;

        public Node insertFront(Node node, HeadNode head)
        {

            node.next = head;
            return node;
        }
        public void print(HeadNode head)
        {
            if(head == null)
            {
                return;
            }
            do
            {
                System.Console.WriteLine(node.value);
                node = node.next;
            } while (node != head);
        }
    }
}
