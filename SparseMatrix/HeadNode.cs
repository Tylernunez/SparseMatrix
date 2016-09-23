using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    abstract class HeadNode : Node
    {
        public abstract HeadNode getNext();

        public abstract ValueNode getFirst();

        public void insert(ValueNode Value)
        {

        }
        public ValueNode get(int position)
        {
            return null;
        }
     
    }
}
