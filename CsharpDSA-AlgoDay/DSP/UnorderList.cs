using CsharpDSA_AlgoDay.DSP.LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.DSP
{
    internal class UnorderList
    {
        public void ReadALlTectFiles(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(",");
            LinkedLis<string> ll = new LinkedLis<string>();
            foreach(var data in words)
            {
                ll.AddLast(data);
            }
            Console.Write("Enter word to search : ");
            string check = Console.ReadLine();
            foreach(var data in words)
            {
                if (data.Equals(check))
                {
                    ll.SearchAndDelete(check);
                    ll.Display();
                    return;
                }
            }
            ll.AddLast(check);
            ll.Display();
        }
    }
}
