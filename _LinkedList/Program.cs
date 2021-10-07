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
            list.AddFirst(50);
            list.AddFirst(4);
            list.AddLast(8);
            list.AddLast(58);
            list.AddLast(9);
            list.AddLast(19);
            list.Show(); 
            
            // Remove functionality check
            list.RemoveFirst();
            list.RemoveLast();

            list.Show();
        }
    }
}