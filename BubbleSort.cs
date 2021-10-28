using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class BubbleSort
    {
        public int[] BubbleSortImplementation(int[] arr)
        {
            
            int loopTimes = arr.Length -1;

            for (int j = 0; j < loopTimes; j++)
            {
                int i = 0;
                while (i < loopTimes)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                    i++;
                }

                loopTimes--;
            }

            
            return arr;
        }
    }
}
