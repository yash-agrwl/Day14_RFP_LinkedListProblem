using System;

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
            Console.WriteLine("Press '4' to Delete the first element in the LinkedList.");
            Console.WriteLine("Press '5' to Delete the last element in the LinkedList.");
            Console.WriteLine("Press '6' to Search LinkedList for a particular Element.");
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
                case "6":
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    int position = list.Search(30);
                    if (position == 0)
                        Console.WriteLine("\nThe Element doesn't exist in the List.");
                    else
                        Console.WriteLine($"\nThe Element with value 30 is in position {position} of the LinkedList.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice Entered.");
                    break;
            }
        }
    }
}
