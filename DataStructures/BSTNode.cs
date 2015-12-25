using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class BSTNode
    {
        public int Data { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set;  }

        public BSTNode(int data, BSTNode leftChild, BSTNode rightChild)
        {
            this.Data = data;
            this.Left = leftChild;
            this.Right = rightChild; 
        }

    }
}
