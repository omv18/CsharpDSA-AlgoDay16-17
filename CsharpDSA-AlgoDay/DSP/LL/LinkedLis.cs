using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpDSA_AlgoDay.DSP.LL
{
    internal class LinkedLis<T>
    {
        int count = 0;
        public Node<T> head;
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
                count++;
                //return;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                count++;
            }
        }

        public void SearchAndDelete(T value)
        {
            if (head == null)
            {
                Console.WriteLine("LL is empty.So we are unable to delete.");
                return;
            }
            if (count == 1)
            {
                head = null;
                count--;
                return;
            }
            Node<T> prev = head;
            Node<T> temp = head.next;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    prev.next = temp.next;
                    temp = null;
                    count--;
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            while (head != null)
            {
                Console.Write(head.data + " -> ");
                head = head.next;
            }
            Console.WriteLine("Null");
        }
    }
}
