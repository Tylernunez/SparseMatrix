﻿using System;
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
            return head;
        }
        public override ValueNode getFirst()
        {
            return node;
        }
    }
}
