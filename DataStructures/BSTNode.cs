using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class BSTNode
    {
        private int Data { get; set; }
        private BSTNode Left { get; set; }
        private BSTNode Right { get; set;  }

        public BSTNode(int data, BSTNode leftChild, BSTNode rightChild)
        {
            this.Data = data;
            this.Left = leftChild;
            this.Right = rightChild; 
        }

    }
}
