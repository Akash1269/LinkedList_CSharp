using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_CSharp
{
    class LinkedList
    {
        Node head;

        public void InsertAtStart(int data)
        {
            Node node = new Node();
            node.Data = data;
            node.Next = head;

            head = node;
        }
        public void PrintList()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty, please insert elements first to get started\n");
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }
        public int GetSize()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }        
    }

}
