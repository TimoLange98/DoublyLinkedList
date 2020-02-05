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
            myListInt.Add(5);

            List<int> myListInt2 = new List<int>();

            myListInt2.Add(6);
            myListInt2.Add(7);
            myListInt2.Add(8);
            myListInt2.Add(9);

            myListInt.AddRange(myListInt2);
            myListInt.Reverse();
            myListInt.Remove(7);

            myListInt.PrintToConsole();
        }
    }
}
