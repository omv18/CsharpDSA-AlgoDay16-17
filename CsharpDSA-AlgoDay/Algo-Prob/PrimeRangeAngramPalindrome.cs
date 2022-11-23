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
                if (CheckPrime(value))
                {
                    if(Palindrome(value)) arrayList.Add(value);
                }
                value++;
            }
        }
        public bool Palindrome(int value)
        {
            int originalCopy = value;
            int duplicateCopy = 0;
            while(value != 0)
            {
                int remainder = value % 10;
                duplicateCopy = duplicateCopy * 10 + remainder;
                value = value / 10;
            }
            if (duplicateCopy == originalCopy) return true;
            else return false;
        }
        public void DisplayPime()
        {
            foreach(var data in arrayList)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
