using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class SortedLinkedList<T> : LinkedList<T> where T : IComparable
    {

        public new void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(this.Head == null || node.Data.CompareTo(Head.Data) <= 0)
            {
                node.Next = this.Head;
                this.Head = node;
            }
            else
            {
                Node<T> temp = this.Head;
                while(temp.Next != null && node.Data.CompareTo(temp.Next.Data) > 0)
                {
                    temp = temp.Next;
                }
                node.Next = temp.Next;
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.Data);
        }
    }
}
