using System;

namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> myListInt = new List<int>();

            myListInt.Add(1);
            myListInt.Add(2);
            myListInt.Add(3);
            myListInt.Add(4);
            myListInt.Add(5);                              // 1, 2, 3, 4, 5 

            List<int> myListInt2 = new List<int>();

            myListInt2.Add(6);
            myListInt2.Add(7);
            myListInt2.Add(8);
            myListInt2.Add(9);

            myListInt.AddRange(myListInt2);                // 1, 2, 3, 4, 5, 6, 7, 8, 9

            myListInt.Reverse();                           // 9, 8, 7, 6, 5, 4, 3, 2, 1

            myListInt.Remove(7);                           // 9, 8, 6, 5, 4, 3, 2, 1


            myListInt.Insert(0, 10);                       // 10, 9, 8, 6, 5, 4, 3, 2, 1
            myListInt.Insert(8, 10);                       // 10, 9, 8, 7, 6, 5, 4, 3, 2, 10, 1

            myListInt.RemoveAt(9);                         // 10, 9, 8, 7, 6, 5, 4, 3, 2, 10)

            int indexOf = myListInt.IndexOf(10);           // 0

            int lastIndexOf = myListInt.LastIndexOf(10);   // 9

            myListInt.PrintToConsole();
            Console.WriteLine(myListInt.Nodes);
            Console.WriteLine(indexOf + " | " + lastIndexOf);
        }
    }
}
