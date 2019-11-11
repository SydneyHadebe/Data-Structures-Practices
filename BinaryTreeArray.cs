using System;

namespace DataStructures
{
    public class BinaryTreeArray
    {
        //Initialize an array here with a fixed length
        static string[] arr = new string[20];

        //The main root on the tree
        public void Root(string key)
        {
            arr[0] = key;
        }

        //Sets the left tree
        public void Set_Left(string key, int root)
        {
            int number = (root * 2) + 1;
            if (arr[root] == null)
            {
                Console.WriteLine("It can't be found in there");
            }
            else
            {
                arr[number] = key;
            }
        }

        //Sets the left tree
        public void Set_Right(string key, int root)
        {
            int number = (root * 2) + 1;
            if (arr[root] == null)
            {
                Console.WriteLine("It can't be found in there");
            }
            else                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
            {
                arr[number] = key;
            }
        }
        //Display the results
        public void Display_Tree()
        {
            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] != null)
                {
                    Console.WriteLine($"{arr[a]}");
                }
                else
                {
                    Console.WriteLine("_");
                }

            }
        }
    }
}
