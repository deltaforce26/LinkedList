using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            {  
                Head = node; 
            }
                
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
                if(current.GetNext() == null)
                {
                    nodes += current.GetValue();
                }
                else
                {
                    nodes += current.GetValue() + " -> ";
                }
                current = current.GetNext();
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
                Node next = current.GetNext();
                current = next;
                length++;
            }
            return length;
        }

        public void RemoveValue(int data)
        {
            if (Head == null)
                return;

            if (Head.GetValue() == data)
            {
                Head = Head.GetNext();
            }

            Node previous = Head;
            Node current = Head;

            while (current != null)
            {
                int value = current.GetValue();
                if (value == data)
                {
                    previous.SetNext(current.GetNext());
                    return;
                }
                previous = current;
                current = current.GetNext();
            }
                    
        }

        public void RemoveAllValues(int data)
        {
            if (Head == null)
                return;

            while (Head != null && Head.GetValue() == data)
            {
                Head = Head.GetNext();
            }

            Node previous = Head;
            Node current = Head;

            while (current != null)
            {
                if (current.GetValue() == data)
                {
                    previous.SetNext(current.GetNext());
                    current = current.GetNext();
                }
                else
                {
                    previous = current;
                    current = current.GetNext();
                }
                
            }
            
        }

        public void RemoveIndex(int data)
        {
            int index = 0;
            if (Head == null)
                return;

            if(Head.GetValue() == data)
            {
                Head = Head.GetNext();
            }

            Node previous = Head;
            Node current = Head;

            while(current != null)
            {
                if(index == data)
                {
                    previous.SetNext(current.GetNext());
                    return;
                }
                current = current.GetNext();
                index++;
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
                current = current.GetNext();
                index++;
            }
            return -1;
        }

        public int Get(int index)
        {
            // 1
            if (Head == null)
                return -1;
            // 1
            int temp = 0;
            // 1
            Node current = Head;
            //            1
            while (current != null)
            {
                //      1
                if (temp == index)
                {
                    return current.GetValue();
                }
                else
                {
                    // 1
                    current = current.GetNext();
                    // 1
                    temp++;
                }
            }
            return -1;
        }
    }
}
