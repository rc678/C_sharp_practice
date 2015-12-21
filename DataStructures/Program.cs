using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //make new linkedlist and test all methods here
            LinkedList currList = new LinkedList(null);
            Node tmp = new Node(5, null);
            currList = currList.Insert(tmp, currList);
            Node tmp2 = new Node(7, null);
            currList = currList.Insert(tmp2, currList);
            Node tmp3 = new Node(9, null);
            currList = currList.Insert(tmp3, currList);

            currList.PrintList(currList);
        }
    }
}
