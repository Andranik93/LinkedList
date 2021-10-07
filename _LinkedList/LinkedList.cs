using System;
using System.Collections.Generic;
using System.Text;

namespace _LinkedList
{
    class LinkedList<T>
    {
        Node<T> head;
        Node<T> tail;
        public int Count { get; set; }
        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head==null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = head.Previous;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = tail.Next;
            }
            Count++;
        }
        public void AddFirst(LinkedList<T> node)
        {
            if (head==null)
            {
                head = node.head;
                tail = node.tail;
            }
            else
            {
                node.tail.Next = head;
                head.Previous = node.tail;
                head = node.tail;
            }
            
        }
        public void AddLast(LinkedList<T> node)
        {
            if (head == null)
            {
                head = node.head;
                tail = node.tail;
            }
            else
            {
                tail.Next = node.head;
                node.head.Previous = tail;
                tail = node.tail;
            }
        }
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
                if (head!=null)
                {
                    head.Previous = null;
                }
            }
        }
        public void RemoveLast()
        {
            if (head != null)
            {
                tail = tail.Previous;
                if (tail != null)
                {
                    tail.Next = null;
                }
            }
        }
        public void Show()
        {
            Node<T> newNode = head;
            while (newNode != null)
            {
                Console.Write(newNode.value + " ");
                newNode = newNode.Next;
            }
            Console.WriteLine();
        }
    }
}
