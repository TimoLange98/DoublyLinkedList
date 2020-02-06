using System;

namespace DoublyLinkedList
{
    public class List<T>
    {
        public Node<T> First;
        public Node<T> Last;
        public int Nodes = 0;

        public void Add(T data)
        {
            if (First == null)
            {
                var add = new Node<T>(null, data, null);
                First = add;
                Last = add;
                Nodes++;
            }
            else
            {
                var add = new Node<T>(Last, data, null);
                Last.Next = add;
                Last = add;
                Nodes++;
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


        public bool Contains(T data)
        {
            var help = First;

            while (help != null)
            {
                if (help.Data.Equals(data))
                    return true;
                help = help.Next;
            }
            return false;
        }


        public bool Exists(Predicate<T> predicate)
        {
            var help = First;

            while (help != null)
            {
                if (predicate(help.Data))
                    return true;
            }
            return false;
        }


        public T Find(Predicate<T> predicate)
        {
            var help = First;

            while (help != null)
            {
                if (predicate(help.Data))
                    return help.Data;
            }
            return default;
        }


        public List<T> FindAll(Predicate<T> predicate)
        {
            return null;
        }

        public void ForEach(Action<T> action)
        {
            var help = First;

            while (help != null)
            {
                action(help.Data);
            }
        }


        public int IndexOf(T data)
        {
            var help = First;
            var index = 0;

            while (help != null)
            {
                if (help.Data.Equals(data))
                    return index;
                help = help.Next;
                index++;
            }
            return -1;
        }
        public int IndexOf(T data, int start)
        {
            var help = First;
            var index = start;

            for (int i = 0; i < start; i++)
            {
                help = help.Next;
            }

            while (help != null)
            {
                if (help.Data.Equals(data))
                    return index;
                help = help.Next;
                index++;
            }
            return -1;
        }


        public void Insert(int index, T data)
        {
            var help = First;

            for (int i = 0; i < index; i++)
            {
                help = help.Next;
            }

            if (help == First)
            {
                var add = new Node<T>(null, data, help);
                help.Prev = add;
                First = add;
            }
            else
            {
                var add = new Node<T>(help.Prev, data, help);
                var temp = help;
                help = add;
                help.Prev.Next = add;
                help.Next = temp;
            }
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
            Nodes--;
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
            T[] result = new T[Nodes];
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
