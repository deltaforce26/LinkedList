using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace data_structures
{
    internal class Node
    {
        public Node(int data)
        {
            Value = data;
        }
        private int Value;
        private Node? Next = null;

        public void SetValue(int data)
        {
            Value = data;
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetNext(Node? node)
        {
            Next = node;
        }

        public Node? GetNext()
        {
            if (Next == null)
            {
                return null;
            }
            return Next;
        }
    }

    internal class LinkedList
    {
        public LinkedList()
        {
            Head = null;
        }

        private Node? Head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (Head == null)
                Head = node;
            else
            {
                Node current = Head;
                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }
                current.SetNext(node);
            }
        }

        public string Display()
        {
            if (Head == null)
                return "";

            string nodes = string.Empty;
            Node current = Head;
            while (current != null)
            {
                nodes += current.GetValue() + "->";
            }
            return nodes;
        }

        public int Length()
        {
            if (Head == null)
                return 0;
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
            }
            return length;
        }

        public void RemoveValue(int data)
        {
            if (Head == null)
                return;

            Node previous = Head;
            Node current = Head;
            while (current != null)
            {
                int value = current.GetValue();
                if (value == data)
                {
                    if (current.GetNext() != null)
                    {
                        previous.SetNext(current.GetNext());
                        return;
                    }
                    else
                    {
                        previous.SetNext(null);
                        return;
                    }
                }
                previous = current;
                if(current.GetNext() == null)
                    return ;
                else
                {
                    current = current.GetNext();
                }
            }
                    
        }

        public void RemoveAllValues(int data)
        {
            if (Head == null)
                return;

            Node previous = Head;
            Node current = Head;
            while (current != null)
            {
                int value = current.GetValue();
                if (value == data)
                {
                    if (current.GetNext() != null)
                    {
                        previous.SetNext(current.GetNext());
                    }
                    else
                    {
                        previous.SetNext(null);
                        
                    }
                }
                previous = current;
                if (current.GetNext() != null)
                    current = current.GetNext();
                else
                {
                    return ;
                }
            }
        }

        public void RemoveIndex(int data)
        {
            int index = 0;
            if (Head == null)
                return;
            Node previous = Head;
            Node current = Head;
            while(current != null)
            {
                if(index == data)
                {
                    current.SetNext(null);
                    if (current.GetNext() != null)
                    {
                        previous.SetNext(current.GetNext());
                        return ;
                    }
                    else
                    {
                        previous.SetNext(null);
                        return;
                    }
                }
            }

        }

        public int Find(int data)
        {
            if(Head == null)
                return -1;
            int index = 0;
            Node current = Head;
            while (current != null)
            {
                if(current.GetValue() == data)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
