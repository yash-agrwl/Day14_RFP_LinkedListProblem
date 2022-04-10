﻿using System;

namespace LinkedListDataStructure
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Linked List Data Structure Problem.\n");

            Console.WriteLine("Press '1' to Add elements to First of LinkedList.");
            Console.WriteLine("Press '2' to Append elements to Last of LinkedList.");
            Console.WriteLine("Press '3' to Insert elements at a Particular Position.");
            Console.WriteLine("Press '4' to delete the first element in the LinkedList.");
            Console.WriteLine("Press '5' to delete the last element in the LinkedList.");
            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            LinkedList<int> list = new LinkedList<int>();

            switch (choice)
            {
                case "1":
                    list.Add(70);
                    list.Add(30);
                    list.Add(56);
                    list.Display();
                    break;
                case "2":
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    break;
                case "3":
                    list.Append(56);
                    list.Append(70);
                    list.InsertAtParticularPosition(2, 30);
                    list.Display();
                    break;
                case "4":
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    Console.Write("\nBefore removing first node, ");
                    list.Display();
                    list.RemoveFirstNode();
                    Console.Write("\nAfter removing first node, ");
                    list.Display();
                    break;
                case "5":
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    Console.Write("\nBefore removing last node, ");
                    list.Display();
                    list.RemoveLastNode();
                    Console.Write("\nAfter removing last node, ");
                    list.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Choice Entered.");
                    break;
            }
        }
    }
}
