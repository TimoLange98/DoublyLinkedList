using System;

namespace DoublyLinkedList
{
    public class List<T>
    {
        public Node<T> First;
        public Node<T> Last;

        public void Add(T data)
        {
            if (First == null)
            {
                var add = new Node<T>(null, data, null);
                First = add;
                Last = add;
            }
            else
            {
                var add = new Node<T>(Last, data, null);
                Last.Next = add;
                Last = add;
            }
        }


        public void AddRange(List<T> add)
        {
            var help = add.First;

            for (int i = 0; i < add.Length(); i++)
            {
                Add(help.Data);
                help = help.Next;
            }
        }


        public void Clear()
        {
            First = Last = null;
        }

        
        public void PrintToConsole()
        {
            var help = First;

            
            while (help != null)
            {
                if (help.Next == null)
                {
                    Console.Write("|" + help.Data + "|\n");
                    break;
                }
                else
                {
                    Console.Write("|" + help.Data + "|->");
                    help = help.Next;
                }
            }
        }


        private int Length()
        {
            var help = First;
            var result = 0;

            while (help != null)
            {
                result++;
                help = help.Next;
            }
            return result;
        }


        public void Remove(T value)
        {
            var help = First;

            while (!help.Data.Equals(value))
            {
                help = help.Next;
            }

            var before = help.Prev;

            before.Next = help.Next;
            help.Next.Prev = before;
        }

        public void RemoveAt(int index)
        {
            Node<T> help = First;
            var count = 0;

            while (count < index && help != null)
            {
                help = help.Next;
                count++;
            }

            
        }


        public void Reverse()
        {
            var help = Last;
            help.SwitchReferences();
            First = help;
            Last = help;

            while (help.Next != null)
            {
                help = help.Next;
                help.SwitchReferences();
                Last.Next = help;
                Last = Last.Next;
            }
        }

        public T[] ToArray()
        {
            T[] result = new T[Length()];
            var help = First;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = help.Data;
                help = help.Next;
            }

            return result;
        }
    }
}
