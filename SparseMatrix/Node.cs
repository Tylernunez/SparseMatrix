using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
   abstract class Node
    {
        private Node nextInRow;
        private Node nextInColumn;
        public Node getNextInRow()
        {
            return this.nextInRow;
        }
        public void setNextInRow(Node next)
        {
            this.nextInRow = next;
        }
        public Node getNextInColumn()
        {
            return this.nextInColumn;
        }
        public void setNextInColumn(Node next)
        {
            this.nextInColumn = next;
        }
    }
}
