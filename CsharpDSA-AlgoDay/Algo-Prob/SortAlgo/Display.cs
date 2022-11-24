using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.SortAlgo
{
    internal class Display
    {
        public void Print(int[] arr)
        {
            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
