using CsharpDSA_AlgoDay.DSP.LL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.DSP
{
    internal class BalancedParentheses
    {
        public void ReadTextFileBalancedParentheses(string filePath)
        {
            string list = File.ReadAllText(filePath);
            string[] words = list.Split(" ");
            LLStack<string> llStack = new LLStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                {
                    llStack.Push(data);
                }
                if (data.Equals(")"))
                {
                    llStack.Pop();
                }

            }
            Console.Write("RESULT is : ");
            if (llStack.Peek()) Console.WriteLine("Balanced Parentheses");
            else Console.WriteLine("Not Balanced Parentheses");
        }
    }
}
