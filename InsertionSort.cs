using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class InsertionSort
    {
        public int[] InsertionSortImplementation(int[] arr)
        {
            //6,5,3,1,8,7,2,4
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        var temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
