using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode()
        {

        }
        public int key;
        public BinaryTreeNode right;
        public BinaryTreeNode left;

        public BinaryTreeNode(int key)
        {
            this.key = key;
            right = null;
            left = null;
        }

        static BinaryTreeNode binaryTreeNode;
        static BinaryTreeNode tempBinaryTreeNode = binaryTreeNode;

        /* Inorder traversal of a binary tree*/
        public static void InOrder(BinaryTreeNode binaryTree)
        {
            if (binaryTree == null)
            {
                return;
            }

            InOrder(binaryTree.left);
            Console.WriteLine($"This is a {binaryTree.key}");
            InOrder(binaryTree.right);
        }

        /*function to insert element in binary tree */
        public static void Insert(BinaryTreeNode insertTemp, int key)
        {
            Queue<BinaryTreeNode> binariesInsert = new Queue<BinaryTreeNode>();
            binariesInsert.Enqueue(insertTemp);

            while (binariesInsert.Count != 0)
            {
                insertTemp = binariesInsert.Peek();

                if (insertTemp.left == null)
                {
                    insertTemp.left = new BinaryTreeNode(key);
                    break;
                }
                else
                {
                    binariesInsert.Enqueue(insertTemp.left);
                }

                if (insertTemp.right == null)
                {
                    insertTemp.right = new BinaryTreeNode(key);
                    break;
                }
                else
                {
                    binariesInsert.Enqueue(insertTemp.right);
                }
            }
        }

        public void CallBinaryTree()
        {
            binaryTreeNode = new BinaryTreeNode(5);
            binaryTreeNode.left = new BinaryTreeNode(15);
            binaryTreeNode.left.left = new BinaryTreeNode(25);
            binaryTreeNode.right = new BinaryTreeNode(10);
            binaryTreeNode.right.left = new BinaryTreeNode(20);
            binaryTreeNode.right.right = new BinaryTreeNode(30);

            Console.Write("Inorder traversal before insertion:");
            InOrder(binaryTreeNode);


            int key = 2;
            Insert(binaryTreeNode, key);

            Console.Write("\nInorder traversal after insertion:");
            InOrder(binaryTreeNode);

        }
    }
}
