using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedList<T> 
    {

        private Node<T> Head;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(Head == null)
                Head = node;
            else
            {
                node.Next = Head;
                this.Head = node;
            }
            Console.WriteLine("{0} inserted into linked list\n", node.Data);
        }

        public void Display()
        {
            Node<T> temp = this.Head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty\n");
                return;
            }
            Console.WriteLine("The Elements in Linked List are displayed below:");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
