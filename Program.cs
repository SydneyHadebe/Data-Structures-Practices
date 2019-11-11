using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    //jagged array always store an array
   public class Students
    {
        public int SubjectID { get; set; }
        public  int Age { get; set; }
        public string StudentName { get; set; }
    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Linear linear = new Linear();
            linear.BubbleSortSearch();
            
            ReplaceAllSpaces("Mr 3ohn Smith");
            //var results = new BinarySearch();
            //results.CheckBinaryResults();
            Permutations("ca", "ac");

            var queue = new Queue(5);
            queue.InsertToTheQueue(60);
            queue.InsertToTheQueue(70);
            queue.InsertToTheQueue(80);
            queue.InsertToTheQueue(90);
            queue.InsertToTheQueue(100);
            queue.InsertToTheQueue(10);
            queue.InsertToTheQueue(20);
            queue.InsertToTheQueue(30);
            queue.InsertToTheQueue(40);
            queue.InsertToTheQueue(50);

            //call the display on the other side
            queue.Display();


            Console.ReadLine();
        }

        //Write a method to replace all spaces in a string with '%20'.
        public static string ReplaceAllSpaces(string name)
        {
            int countSpace = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    countSpace++;
                }
            }
            string store = name.Replace(" ", "%20");
            //Mr%203ohn%20Smith
            //Mr%203ohn%20Smith
            return store;
        }

        // If two strings are permutations, then we know they have the same characters, but in different orders.
        public static bool Permutations(string first, string sec)
        {
            char[] f = first.ToArray();
            char[] s = sec.ToArray();

            Array.Sort(f); Array.Sort(s);

            for (int i = 0; i < f.Length;)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    var results = f[i];

                    if (s.ElementAt(k) == results)
                    {
                        i++;
                        continue;
                    }
                    return false;
                }

                return true;
            }

            //Array.Sort(f); Array.Sort(s);

            //bool same = f.Equals(s);

            //if (!same)
            //{
            //    return false;
            //}

            return true;
        }

        //Implement an algorithm to determine if string has all unique characters
        public static bool UniqueCharacters(string word)
        {
            Boolean[] charSetValues = new Boolean[128];

            for (int i = 0; i < word.Length; i++)
            {
                var value = word.ElementAt(i);
                if (charSetValues[i])
                {
                    return false;
                }

                charSetValues[value] = true;
            }
            return true;
        }

        public static IEnumerable CheckArray()
        {
            ArrayList sentence = new ArrayList() { "T", "H", "S", "U", "P", "O", "M", "L", "TG" };
            ArrayList arrayS = new ArrayList() { "DEV", "JAN", "POLO", "TEST" };


            for (int i = 0; i < sentence.Count; i++)
            {
                sentence.Add(i);
            }


            foreach (var itemlist in arrayS)
            {
                sentence.Add(itemlist);
            }


            return sentence;
        }

        // Array that moves all the zeros to the end
        public static int[] MovesZerosToTheEnd(int[] values)
        {
            int zeroNumbers = 0;
            int[] temp;

            List<int> noneZeros = new List<int>();

            for (int i = 0; i <= values.Length - 1; i++)
            {
                if (values[i] == 0)
                {
                    int store = values[i + 1];
                }
                else if (values[i] != 0)
                {
                    noneZeros.Add(values[i]);
                }
            }
            return null;
        }

        // To sort two arrays using only a while loop and 3 variables.  

        // What is the Big O notation of various algorithms, explain how various tree structures work and the efficiency there of '
        // e.g. AVL, red black trees, explain sorting methods and why or when to use each


        // Given a mutable string (array of characters) of words, how would you reverse the order of the words in the string, not the entire string. 
        public static void LinkedListFeature()
        {
            string[] names = { "Test", "Minions", "Developer", "Coding", "Junior Dev", "Intermediate Dev", "Senior Software Engineer" };

            LinkedList<string> levels = new LinkedList<string>(names);

            levels.AddFirst("Testing GitHub");

            // LinkedListNode<string> mark = levels.First;
            levels.RemoveFirst();
            levels.RemoveLast();


        }
        public static void Test()
        {
            int[][,] arr = new int[3][,] { new int[, ] {{1, 3}, {2,4}, { 4, 7} ,{5, 7}},
                                           new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                           new int[, ] {{11, 22}, {99, 88}, {0, 9}}};
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The first row {i}");

                for (int j = 0; j < arr[i].GetLength(number); j++)
                {
                    for (int k = 0; k < arr[i].Rank; k++)
                        Console.Write(" arr[" + i + "][" + j + ", " + j + "]:" + arr[i][j, j] + " ");
                }

                number++;
            }
        }
        static public void Results(int[] arr)
        {
            var re = arr.Length;

            //For loop
            for (int i = 0; i < arr.Length; i++)
            {
                //var r = arr[i];
                if (arr[i] == 12)
                {
                    Console.WriteLine($"The inside for loop {arr[i]}");
                    break;
                }
                Console.WriteLine($"The Outside for loop {arr[i]}");
                continue;
            }


            //While Loop
            int j = 0;
            while (j < arr.Length)
            {
                if (arr[j] == 12)
                {
                    Console.WriteLine($"The while loop {arr[j]}");
                    break;
                }
                j++;
                continue;
            }


            //do-while 
            int k = 0;
            do
            {
                if (arr[k] == 12)
                {
                    Console.WriteLine($"The do while loop {arr[k]}");
                }
                k++;
            } while (k < arr.Length);

        }
    }

}


// MandateCancellation cancellation = dbMandate.ToMandateCancellation(request);
// if (string.Compare(request.CancellationReason, "MACN", StringComparison.OrdinalIgnoreCase) == 0) //inflight pain.010 cancellation
// {
//   cancellation.MandateRequestTransactionIdentifier = dbMandate.MandateRequestTransactionIdentifier;
//}
//
//