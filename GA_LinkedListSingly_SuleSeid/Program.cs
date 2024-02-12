using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinkedListSingly_SuleSeid
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Testing the LinkedList class
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.WriteLine("Original List:");
            linkedList.Display();

            linkedList.Remove(2);
            Console.WriteLine("List after removing 2:");
            linkedList.Display();

            linkedList.InsertAtIndex(1, 4);
            Console.WriteLine("List after inserting 4 at index 1:");
            linkedList.Display();

            linkedList.InsertAtFront(0);
            Console.WriteLine("List after inserting 0 at the front:");
            linkedList.Display();

            linkedList.InsertAtEnd(5);
            Console.WriteLine("List after inserting 5 at the end:");
            linkedList.Display();

            linkedList.RemoveAtFront();
            Console.WriteLine("List after removing the front element:");
            linkedList.Display();

            linkedList.RemoveAtEnd();
            Console.WriteLine("List after removing the end element:");
            linkedList.Display();

            Console.WriteLine($"Element at index 1: {linkedList[1]}");

            linkedList.Clear();
            Console.WriteLine("List after clearing:");
            linkedList.Display();
        }
    }
    
}
