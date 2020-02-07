using System;

namespace DoublyLinkedList
{
    public class Program
    {
        public bool Prüfen(int data)
        {
            if (data > 9)
            {
                return true;
            }
            return false;
        }

        public void Verdoppeln(int data)
        {
            Console.Write(data * 2 + " -> ");
        }

        public int IstGroesser(int data, int nextData)
        {
            if (data == nextData)
                return 0;
            else if (data > nextData)
                return 1;
            else return -1;
        }

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
            myListInt.Insert(8, 10);                       // 10, 9, 8, 6, 5, 4, 3, 2, 10, 1

            myListInt.RemoveAt(9);                         // 10, 9, 8, 6, 5, 4, 3, 2, 1
            myListInt.RemoveAt(0);                         // 9, 8, 6, 5, 4, 3, 2, 1

            myListInt.Remove(1);                           // 9, 8, 6, 5, 4, 3, 2   

            myListInt.Reverse();                           // 2, 3, 4, 5, 6, 8, 9
            myListInt.Reverse2();                          // 9, 8, 6, 5, 4, 3, 2
            myListInt.PrintToConsole();

            Program p = new Program();
            //Predicate<int> predicate;
            //predicate = p.Prüfen;
            //Console.WriteLine(myListInt.Exists(predicate));

            //Action<int> action;
            //action = p.Verdoppeln;
            //myListInt.ForEach(action);

            Func<int, int, int> comp;

            comp = p.IstGroesser;

            myListInt.Sort(comp);

            myListInt.PrintToConsole();
            
        }
    }
}
