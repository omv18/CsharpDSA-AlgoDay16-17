using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.SortAlgo
{
    internal class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int previous = i - 1;
                while (previous >= 0 && arr[previous] > current)
                {
                    arr[previous + 1] = arr[previous];
                    previous--;
                }
                arr[previous + 1] = current;
            }
        }
    }
}
