using System;
using System.Collections.Generic;
using System.Text;

namespace _LinkedList
{
    class Node<T>
    {
        public T value;
        public Node<T> Next = null;
        public Node<T> Previous = null;
        public Node(T v)
        {
            value = v;
        }
    }
}
