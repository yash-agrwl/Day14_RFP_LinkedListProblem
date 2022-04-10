using System;

namespace LinkedListDataStructure
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Linked List Data Structure Problem.\n");

            LinkedList<int> list = new LinkedList<int>();

            list.Add(70);
            list.Add(30);
            list.Add(56);

            list.Display();
        }
    }
}
