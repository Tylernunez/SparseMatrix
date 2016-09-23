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

        public ValueNode(int row, int column, int value)
        {

        }

        public Node insertFron(Node node, HeadNode head)
        {
            node.setNextInRow(head);
            return node;
        }
        public void print(HeadNode head, Node node)
        {
            if(head == null)
            {
                return;
            }
            do
            {
                System.Console.WriteLine(node.value);
                node = node.nextInRow();
            } while (node != head);
        }
        
           public int getRow
        
    }S
}
