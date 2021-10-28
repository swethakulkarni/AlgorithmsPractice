using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SelectionSort
    {
        public int[] InsertSortImplementation(int[] arr)
        {
            for (int i=0; i< arr.Length; i++)
            {
                int min = arr[i];
                int minIndex = i;
                for (int j=i; j< arr.Length-1; j++)
                {
                    if (arr[j] < arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        min = arr[j+1];
                        minIndex = j+1;
                    }
                }

                var temp2 = arr[i];
                arr[i] = min;
                arr[minIndex] = temp2;
            }
            

            return arr;
        }
    }
}
