using System;
using CsharpDSA_AlgoDay.Algo_Prob;
using CsharpDSA_AlgoDay.DSP;
using CsharpDSA_AlgoDay.DSP.LL;
using CsharpDSA_AlgoDay.SortAlgo;

namespace CsharpDSA_AlgoDay
{
    class Program
    {
        static string binaryFilePath = @"D:\BridgeLabz\DS\CsharpDSA-AlgoDay16-17\CsharpDSA-AlgoDay\Algo-Prob\BinarySearchProblem.txt";
        static string orderFilePath = @"D:\BridgeLabz\DS\CsharpDSA-AlgoDay16-17\CsharpDSA-AlgoDay\DSP\LL\OrderList.txt";
        public static void Main(string[] args)
        {
            Console.Write("1.Algorithum Program 2. DSP : ");
            int check = Convert.ToInt32(Console.ReadLine());
            if (check == 1)
            {
                bool flag = true;
                while (flag)
                {
                    Console.Write("Enter : 1.Sorting Algo 2.BinarySearchWords 3.Regex operation 4.Prime Number 5.Anagram : ");
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
                        case 2:
                            BinarySearchWord binarySearchWord = new BinarySearchWord();
                            binarySearchWord.ReadFileText(binaryFilePath);
                            binarySearchWord.BinarySearch("problem");
                            break;
                        case 3:
                            Regex regex = new Regex();
                            regex.ReplaceWord();
                            break;
                        case 4:
                            PrimeRangeAngramPalindrome prime = new PrimeRangeAngramPalindrome();
                            prime.PrimePalindromeRange(1000);
                            prime.DisplayPrime();
                            break;
                        case 5:
                            AnagramProblem anagramProblem = new AnagramProblem();
                            anagramProblem.AnagramCheck("earth", "haert");
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
            else
            {
                bool flag = true;
                while (flag)
                {
                    Console.Write("Enter : 1.Unsorted 2.OrderList : ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            UnorderList ul = new UnorderList();
                            ul.ReadALlTectFiles(binaryFilePath);
                            break;
                        case 2:
                            OrderList od = new OrderList();
                            od.ReadTextFileSortList(orderFilePath);
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
        }
     }
}