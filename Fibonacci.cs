using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Fibonacci
    {
        private int[] fibonacciSeries;
        public int FibonacciIndex(int index)
        {
            fibonacciSeries = new int[index + 1];
            fibonacciSeries[0] = 0;
            fibonacciSeries[1] = 1;
            if (index > 0)
            {
                for (int i = 2; i <= index; i++)
                {
                    fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
                    if (i == index)
                    {
                        return fibonacciSeries[index];
                    }
                }
            }

            return 0;
        }

        public int FibonacciIndex_Recursion(int index)
        {
            if (index < 2)
            {
                return index;
            }

            if (index > 0)
            {
                return FibonacciIndex_Recursion(index - 1) + FibonacciIndex_Recursion(index - 2);
            }

            return 0;
        }
    }
}
