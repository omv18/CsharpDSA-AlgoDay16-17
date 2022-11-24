using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpDSA_AlgoDay.DSP.LL
{
    internal class LLStack<T>
    {
        private Node<T> top;
        public LLStack()
        {
            this.top = null;
        }
        internal void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            //Console.WriteLine("{0} is push on the stack", value);
        }
        internal void Display()
        {
            Node<T> temp = this.top;
            Console.Write("Null");
            while (temp != null)
            {
                Console.Write(" <- " + temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal bool Peek()
        {
            if (this.top == null)
            {
                ///Console.WriteLine("stack is empty");
                return true;
            }
            //Console.WriteLine("{0} is the top of the data", this.top.data);
            return false;
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                //Console.WriteLine("stack is empty");
                return;
            }
            //Console.WriteLine("Value is popped is {0}", this.top.data);
            this.top = this.top.next;
        }
    }
}
