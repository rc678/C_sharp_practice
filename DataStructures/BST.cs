using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class BST
    {
        public BSTNode Root { get; set; }

        public BST(BSTNode root)
        {
            this.Root = root;
        }

        public BSTNode Insert(BSTNode nodeToInsert, BSTNode currentTree)
        {
            if (currentTree == null || nodeToInsert == null)
            {
                Console.WriteLine("Cannot have empty tree or node");
                return currentTree;
            }
            else
            {
                BSTNode curr = currentTree;
                BSTNode parentNode = null;

                while (curr != null)
                {
                    if (curr.Data == nodeToInsert.Data)
                    {
                        Console.WriteLine("Node already exists");
                        return currentTree;
                    }else if (curr.Data < nodeToInsert.Data)
                    {
                        parentNode = curr;
                        curr = curr.Right;
                        if (curr == null)
                        {
                            parentNode.Right = nodeToInsert;
                            return currentTree;
                        }
                    }else if (curr.Data > nodeToInsert.Data)
                    {
                        parentNode = curr;
                        curr = curr.Left;
                        if (curr == null)
                        {
                            parentNode.Left = nodeToInsert;
                            return currentTree;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Data is not less than, greater than, or equal to any nodes");
                        return currentTree; 
                    }
                }
            }

            return null;
        }

        public void Inorder(BSTNode currentTree)
        {
            if (currentTree == null)
            {
                return;
            }
            Inorder(currentTree.Left);
            Console.WriteLine(currentTree);
            Inorder(currentTree.Right);
        }

        public void Preorder(BSTNode currentTree)
        {
            if (currentTree == null)
            {
                return;
            }
            Console.WriteLine(currentTree);
            Preorder(currentTree.Left);
            Preorder(currentTree.Right);
        }

        public void Postorder(BSTNode currentTree)
        {
            if (currentTree == null)
            {
                return;
            }
            Postorder(currentTree.Left);
            Postorder(currentTree.Right);
            Console.WriteLine(currentTree.Data);
        }

        public void Delete(BSTNode nodeToDelete, BSTNode currentTree)
        {
            
        }

    }
}
