using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node next;

        public void Display()
        {
            Console.WriteLine($"The {data}");
        }
    }

    public class SinglyLinkedList
    {
        private Node firstNode;

        public bool isEmpty() { return firstNode == null; }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = firstNode;
            firstNode = newNode;
        }
                                                                                                                                                                 
        public void InsertLast(int data)
        {
            Node currentNodeInsert = firstNode;
            while (currentNodeInsert != null)
            {
                currentNodeInsert = currentNodeInsert.next;
                currentNodeInsert.next = firstNode;
            }

            Node newNode = new Node();
            newNode.data = data;
            currentNodeInsert.next = newNode;
        }

        public Node DeleteFirstNode()
        {
            Node temp = firstNode;
            firstNode = firstNode.next;
            return temp;
        }

        public void displayList()
        {
            Console.WriteLine("First and Last");
            Node currentNode = firstNode;

            while (currentNode != null)
            {
                currentNode.Display();
                currentNode = currentNode.next;
            }

            Console.WriteLine();
        }

       
    }
}
