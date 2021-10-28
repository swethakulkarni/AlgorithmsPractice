using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class QuickSort
    {
        public int[] QuickSortImplementation(int[] array)
        {

            if (array.Length <=1)
            {
                return array;
            }
            
            int pivot = array.Length -1 ;
            int pointer = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (pivot > pointer && array[pointer] > array[pivot])
                {
                    if (pointer == pivot-1)
                    {
                        int temp2 = array[pivot];
                        array[pivot] = array[pointer];
                        array[pointer] = temp2;
                        pivot -= 1;
                    }
                    else
                    {
                        int temp = array[pivot - 1];
                        array[pivot - 1] = array[pivot];
                        array[pivot] = array[pointer];
                        array[pointer] = temp;
                        pivot -= 1;
                    }
                }
                else if (pivot > pointer && array[pointer] < array[pivot] && pointer+1 != pivot)
                {
                    pointer += 1;
                }
            }

            if (pivot == array.Length - 1 && pointer == pivot - 1)
            {
                return array;
            }

            QuickSortImplementation(array.Take(pivot).ToArray());
            QuickSortImplementation(array.Skip(pivot).ToArray());

            return array;
        }
    }
}
