using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.Algo_Prob
{
    internal class PrimeRangeAngramPalindrome
    {
        ArrayList arrayList = new ArrayList();
        public bool CheckPrime(int n)
        {
            if (n <= 1)
                return false;

            int i = 2;
            while (i <= n / 2)
            {
                if ((n % i) == 0)
                    return false;
                i++;
            }

            return true;
        }

        public void PrimeRange(int range)
        {
            int value = 2;
            while(range != value)
            {
                if(CheckPrime(value))
                    arrayList.Add(value);
                value++;
            }
        }
        public void DisplayPime()
        {
            foreach(var data in arrayList)
            {
                Console.Write(data + " ");
            }
        }
    }
}
