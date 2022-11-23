using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDSA_AlgoDay.Algo_Prob
{
    internal class Regex
    {
        string sentences = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.";
        public void ReplaceWord()
        {
            Console.Write("Enter the name : ");
            string name = Console.ReadLine();
            sentences = sentences.Replace("<<name>>", name);

            Console.Write("Enter the full name : ");
            string fullName = Console.ReadLine();
            sentences = sentences.Replace("<<full name>>", fullName);

            Console.Write("Enter the mobile number : ");
            string mobile = Console.ReadLine();
            sentences = sentences.Replace("xxxxxxxxxx", mobile);

            Console.WriteLine(sentences);
        }
    }
}
