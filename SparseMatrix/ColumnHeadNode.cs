using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    class ColumnHeadNode : HeadNode
    {
        public override HeadNode getNext()
        {
            return (HeadNode)getNextInColumn();
        }
        public override ValueNode getFirst()
        {
            return null;
        }
        public ValueNode get(int position)
        {
            for (int i = 0; i <= position; i++)
            {
                if (i == position - 1)
                {
                    ValueNode result = (ValueNode)getNextInColumn();
                    return result;
                }
                getNextInColumn();
            }
            return null;
        }
    }
}
