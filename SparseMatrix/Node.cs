using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
   abstract class Node
    {
        private Node nextInRow()
        {
            return null;
        }
        private Node nextInColumn()
        {
            return null;
        }
    }
}
