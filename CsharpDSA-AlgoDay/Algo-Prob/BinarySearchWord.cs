using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.Algo_Prob
{
    internal class BinarySearchWord
    {
        string[] binaryArr;
        public void ReadFileText(string filePath)
        {
            string words = File.ReadAllText(filePath);
            binaryArr = words.Split(",");
        }
        public void BinarySearch(string serach)
        {
            foreach(var word in binaryArr)
            {
                if (word.Equals(serach))
                {
                    Console.WriteLine("Match is found in the given string.");
                    return;
                }
                Console.WriteLine("Match is not found in the given string.");
            }
        }
    }
}
