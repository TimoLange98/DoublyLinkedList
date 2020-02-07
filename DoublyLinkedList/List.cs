﻿using System;

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

            for (int i = 0; i < add.Count(); i++)
            {
                Add(help.Data);
                help = help.Next;
            }
        }


        public void Clear()
        {
            First = Last = null;
        }


        private int Count()
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
                    return true; help = help.Next;
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
                help = help.Next;
            }
            return default;
        }


        public List<T> FindAll(Predicate<T> predicate)
        {
            var help = First;
            List<T> result = new List<T>();

            while (help != null)
            {
                if (predicate(help.Data))
                {
                    result.Add(help.Data);
                }
                help = help.Next;
            }
            return result;
        }


        public int FindIndex(Predicate<T> predicate)
        {
            var help = First;
            var index = 0;

            while (help != null)
            {
                if (predicate(help.Data))
                    return index;
                help = help.Next;
                index++;
            }
            return -1;
        }
        public int FindIndex(int start, Predicate<T> predicate)
        {
            var help = First;

            for (int i = 1; i < start; i++)
            {
                return 0;
            }
            return 0;
        }


        public void ForEach(Action<T> action)
        {
            var help = First;

            while (help != null)
            {
                action(help.Data);
                help = help.Next;
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

            if (index < 0 || index > Nodes - 1)
            {
                throw new Exception("Index outside of the bounds of the List");
            }

            for (int i = 0; i < index; i++)
            {
                help = help.Next;
            } 

            if (help == First)
            {
                var add = new Node<T>(null, data, help);
                help.Prev = add;
                First = add;
                Nodes++;
            }
            else
            {
                var add = new Node<T>(help.Prev, data, help);
                var temp = help;
                help = add;
                help.Prev.Next = add;
                help.Next = temp;
                help.Next.Prev = add;
                Nodes++;
            }
        }


        public int LastIndexOf(T data)
        {
            var help = Last;
            var index = Nodes;

            while(help != null)
            {
                if (help.Data.Equals(data))
                    return index;
                help = help.Prev;
                index--;
            }
            return -1;
        }
        public int LastIndexOf(T data, int start)
        {
            var help = Last;
            var index = Nodes - 1;

            for (int i = index; i != start; i--)
            {
                help = help.Prev;
                index--;
            }

            while (help != null)
            {
                if (help.Data.Equals(data))
                    return index;
                help = help.Prev;
                index--;
            }
            return -1;
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


        public void Remove(T value)
        {
            var help = First;

            while (!help.Data.Equals(value))            
            {
                if (help.Next == null)
                    return;

                help = help.Next;
            }

            if (help == First)
            {
                First = help.Next;
                First.Prev = null;
            }
            else if (help == Last)
            {
                Last = help.Prev;
                Last.Next = null;
            }
            else
            {
                help.Prev.Next = help.Next;
                help.Next.Prev = help.Prev;
            }
            Nodes--;
        }


        public void RemoveAll(T value)
        {
            var help = First;
            
            while (help != null)
            {
                if (help.Data.Equals(value))
                {
                    Remove(value);
                }
                help = help.Next;
            }
        }


        public void RemoveAt(int index)
        {
            Node<T> help;

            if (index < 0 || index > Nodes - 1)
            {
                throw new Exception("Index outside of the bounds of the List");
            }

            if (index > Nodes / 2)
            {
                help = Last;

                for (int i = 0; i < Nodes - index; i++)
                {
                    help = help.Prev;
                }
                if (help == Last)
                {
                    Last = help.Prev;
                    Last.Next = null;
                    Nodes--;
                }
                help.Prev.Next = help.Next;
                help.Next.Prev = help.Prev;
                Nodes--;
            }
            else                                                    
            {
                help = First;

                for (int i = 0; i < index; i++)
                {
                    help = help.Next;
                }

                if (help == First)
                {
                    First = help.Next;
                    First.Prev = null;
                    Nodes--;
                }
                else
                {
                    help.Prev.Next = help.Next;
                    help.Next.Prev = help.Prev;
                    Nodes--;
                }
                
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
        public void Reverse2()
        {
            var help = First;

            while (help != null)
            {
                var temp = help.Next;
                help.Next = help.Prev;
                help.Prev = temp;

                help = help.Prev;

            }

            var first = First;
            First = Last;
            Last = first;
        }


        public void Sort(Func<T, T, int> compare)
        {
            var help = First;

            while (help != null)
            {
                if (compare(help.Data, help.Next.Data) == 1)
                {
                    SwitchNodes(help, help.Next);
                }

                help = help.Next;
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


        public void SwitchNodes(Node<T> node, Node<T> nextNode)
        {
            if (node == First)
            {
                First = nextNode;
                First.Prev = null;
                First.Next = node;
            }

            else if (node == Last)
            {
                Last = node;
                Last.Next = null;
                Last.Prev = nextNode;
            }

            else
            {
                var tempNode = node;
                var tempNextNode = nextNode;

                node = nextNode;
                nextNode = tempNode;

                node.Prev = tempNode.Prev;
                node.Next = nextNode;

                nextNode.Prev = node;
                nextNode.Next = tempNextNode.Next;
            }
        }
    }

    static class MyExtension
    {
        public static char GetValue(this string value, int index)
        {
            return value[index];
        }
    }
}
