using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpDSA_AlgoDay.DSP.LL
{
    internal class LinkedLis<T> where T : IComparable
    {
        int count = 0;
        public Node<T> head;
        public Node<T> tail;
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
                count++;
                //return;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
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
        public void sortList()
        {

            // Node current will point to head
            Node<T> current = head, index = null;

            T temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    // Node index will point to node next to
                    // current
                    index = current.next;

                    while (index != null)
                    {
                        // If current node's data is greater
                        // than index's node data, swap the data
                        // between them
                        if ((current.data).CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }

                        index = index.next;
                    }
                    current = current.next;
                }
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
