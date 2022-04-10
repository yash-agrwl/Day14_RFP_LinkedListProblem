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
            if(this.Head == null)
                this.Head = node;
            else
            {
                node.Next = Head;
                this.Head = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.Data);
        }

        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.Head == null)
                this.Head = node;
            else
            {
                Node<T> temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.Data);
        }

        public void InsertAtParticularPosition(int position, T data)
        {
            if (position < 1)
            {
                Console.WriteLine($"{data} cannot be inseted due to Invalid Position");
                return;
            }
            Node<T> node = new Node<T>(data);
            if (position == 1)
            {
                node.Next = this.Head;
                Head = node;
                Console.WriteLine($"{data} inserted at position {position} of linked list");
            }
            else
            {
                Node<T> temp = this.Head;
                int count = 1;
                while (temp != null)
                {
                    if (count == position - 1)
                    {
                        node.Next = temp.Next;
                        temp.Next = node;
                        Console.WriteLine($"{data} inserted at position {position} of linked list");
                        return;
                    }
                    else
                    {
                        temp = temp.Next;
                        count++;
                    }
                }
                Console.WriteLine($"{data} cannot be inserted due to Position out of range.");
            }
        }

        public void RemoveFirstNode()
        {
            if (this.Head == null)
                return;
            this.Head = this.Head.Next;
        }

        public void RemoveLastNode()
        {
            if (this.Head == null)
                return;
            Node<T> temp = this.Head;
            Node<T> pointer = temp.Next;
            while (pointer.Next != null)
            {
                temp = pointer;
                pointer = pointer.Next;
            }
            temp.Next = null;
        }

        public int Search(T value)
        {
            Node<T> node = this.Head;
            int count = 0;
            while (node != null)
            {
                count++;
                if (node.Data.Equals(value))
                    return count;
                node = node.Next;
            }
            return count=0;
        }

        public void RemoveAtParticularPosition(int position)
        {
            if (position < 1)
                return;
            if (position == 1)
            {
                RemoveFirstNode();
                return;
            }
            else
            {
                Node<T> temp = this.Head;
                Node<T> pointer = temp.Next;
                for (int count = 1; count<position-1; count++)
                {
                    temp = temp.Next;
                    pointer = temp.Next; 
                }
                temp.Next = pointer.Next;
                pointer.Next = null;
            }
        }

        public int size()
        {
            Node<T> temp = this.Head;
            int count = 0;
            if(temp == null)
                return count;
            else
            {
                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }
                return count;
            }
        }

        public void Display()
        {
            Node<T> temp = this.Head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty.");
                return;
            }
            Console.WriteLine("\nThe Elements in Linked List are:");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
