using System;
using CsharpDSA_AlgoDay.SortAlgo;

namespace CsharpDSA_AlgoDay
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter : 1.Sorting Algo");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int[] arr = { 5, 27, 28, 2, 1, 9 };
                        int[] arr1 = { 5, 7, 18, 2, 21, 19 };
                        int[] arr2 = { 5, 17, 8, 2, 11, 9 };
                        InsertionSort insertionSort = new InsertionSort();
                        BubbleSort bubbleSort = new BubbleSort();
                        MergeSort mergeSort = new MergeSort();
                        Display display = new Display();    
                        mergeSort.Sort(arr, 0, arr.Length - 1);
                        bubbleSort.Sort(arr1);
                        insertionSort.Sort(arr2);
                        display.Print(arr);
                        display.Print(arr1);
                        display.Print(arr2);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
     }
}