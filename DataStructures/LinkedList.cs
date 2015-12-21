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
        /// Inserts a node to the end of a Linked List
        /// </summary>
        /// <param name="nodeToInsert">node to insert at the end of list</param>
        /// <param name="currList"> list in which node is inserted </param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataToDelete"></param>
        /// <param name="currList"></param>
        /// <returns></returns>
        public LinkedList Delete(int dataToDelete, LinkedList currList)
        {
            if (currList == null) //list is empty
            {
                return currList;
            }
            else
            {
                if (currList.Head.Next == null) //list contains only 1 node
                {
                    if (currList.Head.Data == dataToDelete)
                    {
                        return null;
                    }
                    else
                    {
                        return currList;
                    }
                }
                else //list contains 2+ nodes
                {
                    Node curr = currList.Head;
                    Node prev = null;
                    while (curr != null)
                    {
                        if (curr.Data == dataToDelete)
                        {
                            prev.Next = curr.Next;
                            curr.Next = null;
                            curr = prev.Next; 
                        }

                        prev = curr;
                        curr = curr.Next; 
                    }/*end of while loop*/
                }/*end of else statement*/
            }/*end of else*/ 
            
            return currList;
        }/*end of delete*/
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currList"></param>
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
