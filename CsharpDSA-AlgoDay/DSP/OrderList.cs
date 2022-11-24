using CsharpDSA_AlgoDay.DSP.LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.DSP
{
    internal class OrderList
    {
        public void ReadTextFileSortList(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            LinkedLis<int> sortingList = new LinkedLis<int>();
            foreach (var data in words)
            {
                int result = Convert.ToInt32(data);
                sortingList.AddLast(result);
            }
            Console.WriteLine("After sort");
            sortingList.sortList();
            sortingList.Display();
        }
    }
}
