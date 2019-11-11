using System;

namespace DataStructures
{
    public class BinarySearch
    {
        // Finds the position of a target value within a sorted array
        public void CheckBinaryResults()
        {
            int[] values = { 2, 5, 33, 45, 66, 74, 80, 82, 87, 88, 91, 96, 98 };
            int target = 88;

            Array.ForEach(values, a => Console.Write(a + " "));

            Console.Write(($"The results of the serach is {target} is: "));

            Console.WriteLine(BinarySearcgTarget(values, target));
        }

        public static int BinarySearcgTarget(int[] values, int target)
        {
            int startValue = 0;
            int endValue = values.Length - 1;
            int middleValue;

            if (startValue <= endValue)
            {
                middleValue = (endValue) / 2; //Find a Middle Value
                middleValue = (startValue + endValue ) / 2;
            }


            while (startValue <= endValue)
            {
                middleValue = (endValue) / 2; //Find a Middle Value

                if (target < values[middleValue])
                {
                    endValue = middleValue - 1;
                }
                else if(target > values[middleValue])
                {
                    startValue = middleValue + 1;

                    //int results = values[middleValue + 1];
                }
                else
                {
                    return middleValue;
                }
            }
            return -1;
        }
    }

}

