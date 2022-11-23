using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.Algo_Prob
{
    internal class AnagramProblem
    {
        public void AnagramCheck(string a, string b)
        {
            string first = Test(a);
            string second = Test(b);
            if (first.Equals(second))
                Console.WriteLine("Given string is angarm.");
            else 
                Console.WriteLine("Given string is not angarm.");
        }
        public string Test(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }  
    }
}
