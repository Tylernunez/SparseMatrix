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
            this.row = row;
            this.column = column;
            this.value = value;
        }

        public void print(HeadNode head, ValueNode node)
        {
            if(head == null)
            {
                return;
            }
            do
            {
                System.Console.WriteLine(node.getValue());
                node.setNextInRow(head);
            } while (node != head);
        }
        
           
        public int getRow()
        {
            return this.row;
        }
        public void setRow(int row)
        {
            this.row = row;
        }
        public int getColumn()
        {
            return this.column;
        }
        public void setColumn(int column)
        {
            this.column = column;
        }
        public int getValue()
        {
            return this.value;
        }
        public void setValue(int value)
        {
            this.value = value;
        }
    }
}
