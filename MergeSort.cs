using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class MergeSort
    {

        public int[] MergeSortImplementation(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            var array1 = array.Take(array.Length / 2).ToArray();
            var array2 = array.Skip(array.Length / 2).ToArray();
            return Merge(MergeSortImplementation(array1), MergeSortImplementation(array2));
        }

        public int[] Merge(int[] leftArray, int[] rightArray)
        {
            List<int> result = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                result.Add(leftArray[leftIndex]);

            }
            else
            {
                result.Add(rightArray[rightIndex]);
            }
            return result.ToArray();
        }

        
    }
}
