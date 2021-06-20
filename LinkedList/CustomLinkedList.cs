using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    /// <summary>
    /// Double Linked List
    /// </summary>
    public class CustomLinkedList
    {
        public int Count { get; private set; }

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public CustomLinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public CustomLinkedList(int value)
            :this()
        {
            Head = Tail = new Node()
            {
                Value = value,
                Next = null,
                Previous = null
            };
            Count++;
        }

        public CustomLinkedList(IEnumerable<int> list)
            :this(list.First())
        {
            bool isFirst = true;
            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    Node newNode = new Node()
                    {
                        Value = item,
                        Previous = Tail,
                        Next = null
                    };

                    Tail.Next = newNode;
                    Tail = newNode;
                    Count++;
                }
            }
        }

        public void AddFirst(int element)
        {
            Node newNode = new Node() { Value = element };
            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            Node newNode = new Node() { Value = element };
            if (Count == 0)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count>0)
            {
                int result = Head.Value;
                Node second = Head.Next;
                if (second == null)
                {
                    Tail = null;
                }
                else
                {
                    second.Previous = null;
                }
                Head = second;
                Count--;
                return result;
            }
            throw new IndexOutOfRangeException("Empty List");
        }

        public int RemoveLast()
        {
            if (Count > 0)
            {
                int result = Tail.Value;
                Node prev = Tail.Previous;
                if (prev == null)
                {
                    Head = null;
                }
                else
                {
                    prev.Next = null;
                }
                Tail = prev;
                Count--;
                return result;
            }
            throw new IndexOutOfRangeException("Empty List");
        }
    }
}
