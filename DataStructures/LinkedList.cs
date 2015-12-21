using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public LinkedList(Node head)
        {
            this.Head = head; 
        }

        /// <summary>
        /// Inserts a node to the end of a LinkedList
        /// </summary>
        /// <param name="nodeToInsert"></param>
        /// <param name="currList"></param>
        /// <returns></returns>
        public LinkedList Insert(Node nodeToInsert, LinkedList currList)
        {
            if (nodeToInsert == null) //inserting null node
            {
                Console.WriteLine("Cannot insert Null node");
                return currList;
            }

            if (currList.Head == null)//if list is empty
            {
                currList.Head = nodeToInsert;
                currList.Tail = nodeToInsert;
            }
            else//appending to the end of list
            {
                currList.Tail.Next = nodeToInsert;
                currList.Tail = currList.Tail.Next; 
            }

            return currList; 
        }/*end of insert method*/

        public void PrintList(LinkedList currList)
        {
            Node ptr = currList.Head;

            while (ptr != null)
            {
                Console.Write(ptr.Data + " ");
                ptr = ptr.Next;
            }

        }/*end of printlist method*/
    }
}
