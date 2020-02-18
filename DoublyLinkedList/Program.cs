using System;

namespace DoublyLinkedList
{
    public class Program
    {
        public bool Prüfen(int data)
        {
            if (data > 9)
                return true;
            return false;
        }


        public bool Prüfen2(int data)
        {
            if (data < 0)
                return true;
            return false;
        }


        public void Verdoppeln(int data)
        {
            Console.Write(data * 2 + " -> ");
        }

        public int IstGroesserInt(int data, int nextData)
        {
            if (data == nextData)
                return 0;
            else if (data > nextData)
                return 1;
            else return -1;
        }

        public int IstGroesserString(string data, string nextData)
        {
            if (data.Length == nextData.Length)
                return 0;
            else if (data.Length > nextData.Length)
                return 1;
            else return -1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Func<int, int, int> comparisonInt;

            comparisonInt = p.IstGroesserInt;





            List<int> myListInt = new List<int>();

            myListInt.Add(5);
            myListInt.Add(134);
            myListInt.Add(56);
            myListInt.Add(15);
            myListInt.Add(2);
            myListInt.Add(579);
            myListInt.Add(24);                                  // 5, 134, 56, 15, 2, 579, 24

            //myListInt.PrintToConsole(); Console.WriteLine();

            //myListInt.ReverseOnlyData();                        // 24, 579, 2, 15, 56, 134, 5

            //myListInt.PrintToConsole(); Console.WriteLine();

            myListInt.SortInsertion(comparisonInt);             // 2, 5, 15, 24, 56, 134, 579

            myListInt.PrintToConsole(); Console.WriteLine();

        }
    }
}
