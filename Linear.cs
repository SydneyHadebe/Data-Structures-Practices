using System;

namespace DataStructures
{
    //Searching Algorithms
    public class Linear
    {
        public void InsertionSearch()
        {
            int[] values = { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };
            InsertionSort(values);
        }
        public void CountingSortSearch()
        {
            int[] array = new int[10]
            {
              2, 5, -4, 11, 0, 8, 22, 67, 51, 6
            };

            CountingSort(array);
        }
        public void BubbleSortSearch()
        {
            int[] values = { 3, 0, 9, 2, 5, -1, 4, 1 };
            BubbleSort(values);

        }
        public void CallInterpolationSearch()
        {
            int[] values = { 16, 21, 22, 39, 41, 47, 49, 52, 57, 60, 65, 71, 77, 90, 91 };

            int target = 77;

            Console.WriteLine(InterpolationSearchData(values, target));
        }
        public void CallBinarySearch()
        {
            int[] values = { 16, 21, 22, 39, 41, 47, 49, 52, 57, 60, 65, 71, 77, 90, 91 };

            int target = 77;

            Console.WriteLine(BinarySearchData(values, target));
        }
        public void CallLinear()
        {
            int[] values = { 16, 21, 22, 39, 41, 47, 49, 52, 57, 60, 65, 71, 77, 90, 91 };
            int target = 77;

            Console.WriteLine(LinearSearchData(values, target));
        }

        /// //This algorithm is much slower than binary search or interpolation search, but
        //    it has the advantage that it works on linked lists and unsorted lists

        public void InsertionSort(int[] values)
        {
            //Iterate through the array, starting from the second element:
            for (int x = 1; x < values.Length - 1; x++)
            {
              int currentValue = values[x];
              int k = x - 1;

                while (k > 0 && values[k] > currentValue)
                {
                    values[k - 1] = values[k];
                    k = k - 1;
                }

                values[k - 1] = currentValue;
            }
        }

        public void CountingSort(int[] values)
        {
           // int[] num = new int[values.Length];

            //smallest and largest number
            int minValue = values[0];
            int maxValue = values[0];
            // 2, 5, -4, 11, 0, 8, 22, 67, 51, 6

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                }
                else if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }


            int[] count = new int[maxValue - minValue + 1];

            for (int i = 0; i < values.Length; i++)
            {
                count[values[i] - minValue]++;
            }

            count[0]--;

            for (int i = 0; i < values.Length; i++)
            {
                count[i] = count[i] + count[i + 1];

            }


            //sort the array
            for (int i = values.Length - 1; i >= 0; i--)
            {
                int[] num1 = new int[values.Length];

                num1[count[values[i] - minValue]--] = values[i];
            }

        }

        // int sort 
        public void BubbleSort(int[] values)
        {
            // for (int i = 0; i < values.Length - 1; i++)
            //{
            for (int j = 0; j <= values.Length - 1; j++)
            {
                if (values[j] > values[j + 1])
                {
                    int number = values[j + 1];
                    values[j + 1] = values[j];
                    values[j] = number;
                }
            }

            for (int y = 0; y < values.Length - 1; y++)
            {
                int storeTempValue = 0;
                if (values[y] > values[y + 1])
                {
                    values[y] = values[y + 1];
                    values[y + 1] = values[y];
                }

                if (storeTempValue == 0)
                {
                    break;
                }
            }
        }

        public int LinearSearchData(int[] values, int target)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] == target)
                {
                    return i;
                }

                if (values[i] > target)
                {
                    return -1;
                }

                continue;
            }

            return -1;
        }

        public int BinarySearchData(int[] values, int target)
        {
            int smallest = 0;
            int largest = values.Length - 1;
            while (smallest <= largest)
            {
                int middle = (smallest + largest) / 2;
                if (target < values[middle])
                {
                    largest = middle - 1;
                }

                if (target > values[middle])
                {
                    smallest = middle + 1;
                }
                return middle;
            }
            return -1;
        }

        public int InterpolationSearchData(int[] values, int target)
        {
            int minimum = 0;
            int maximum = values.Length - 1;

            while (minimum <= maximum)
            {
                int middleValue = minimum + (maximum - minimum) * (target - values[minimum]) / (values[maximum] - values[minimum]);

                if (values[middleValue] == target)
                {
                    return middleValue;
                }

                //<Set min or max to search the left or right half.>
            }
            return -1;
        }
    }
}

