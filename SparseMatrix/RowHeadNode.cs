﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    class RowHeadNode : HeadNode
    {
        public override HeadNode getNext()
        {   
            return (HeadNode)getNextInRow();
        }
        public override ValueNode getFirst()
        {
            return null;
        }
    }
}
