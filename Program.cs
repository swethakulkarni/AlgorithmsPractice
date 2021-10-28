using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Factorial 

            //FactorialRecursive factorial = new FactorialRecursive();
            //factorial.Factorial(-3);

            //Fibonacci
            //Fibonacci fibonacci = new Fibonacci();
            //var result = fibonacci.FibonacciIndex(4);
            //var resultRecursion = fibonacci.FibonacciIndex_Recursion(15);

            //SelectionSort selectionSort = new SelectionSort();
            //InsertionSort insertionSort = new InsertionSort();
            //MergeSort mergeSort = new MergeSort();
            //int[] input = new int[]{7, 3, 1, 5, 6, 2, 4, 8};
            //var result = insertionSort.InsertionSortImplementation(input);
            //var result = mergeSort.MergeSortImplementation(input);

           var quickSort = new QuickSort();
           int[] input = new[] {3,5,7,6, 2, 1, 4};
           var result = quickSort.QuickSortImplementation(input);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
