using System;

namespace _LinkedList
{
    class Program
    {  
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(7);
            list.AddFirst(6);
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddLast(8);
            list.AddLast(9);
            list.Show(); 
            
            list.RemoveFirst();
            list.RemoveLast();

            list.Show();
        }
    }
}