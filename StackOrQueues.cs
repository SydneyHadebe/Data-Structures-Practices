using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class StackOrQueues
    {
        private int maxSize;
        private string[] stackArray;
        private int top;


        public StackOrQueues(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void Push(string insertMember)
        {
            if (isFull())
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                top++;
                stackArray[top] = insertMember;
            }
        }

        public string Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Its empty");
                return "-empty man-";
            }
            else {
                int topNumber = top;
                top--;
                return stackArray[topNumber];
            }
        }

        public bool isEmpty()
        {

            return top == - 1;
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }

}

