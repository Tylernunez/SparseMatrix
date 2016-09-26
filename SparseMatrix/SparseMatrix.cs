using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    class SparseMatrix : Node
    {
        public void insert(int row,int column, int value)
        {
            RowHeadNode rowHead = (RowHeadNode)getRow(row);
            ColumnHeadNode columnHead = (ColumnHeadNode)getColumn(column);
            ValueNode myValueNode = new ValueNode(row, column, value);
            rowHead.insert(myValueNode);
            columnHead.insert(myValueNode);
        }
        public int getValue(int row, int column)
        {
            for(int i = 0; i <= row; i++)
            {
                for(int j=0;j <=column; j++)
                {
                    if(i == row && j == column)
                    {
                        ValueNode result = getNext();
                    }
                }
            }
            return 0;
        }
        public void print()
        {

        }
        public HeadNode getRow(int position)
        {
            for(int i = 0; i <= position; i++)
            {
                if(i == position)
                {
                    RowHeadNode result = new RowHeadNode();
                    return result;
                }
                getNextInRow();
            }
            
            return null;
        }
        public HeadNode getColumn(int position)
        {
            for (int i = 0; i <= position; i++)
                {
                    if (i == position)
                    {
                        ColumnHeadNode result = new ColumnHeadNode();
                        return result;
                    }
                    getNextInColumn();
                }

                return null;
        }
        public SparseMatrix transpose()
        {
            return null;
        }
        public SparseMatrix product()
        {
            return null;
        }

    }
}
