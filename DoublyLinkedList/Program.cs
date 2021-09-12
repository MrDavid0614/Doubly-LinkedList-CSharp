using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dlinkedlist = new DoublyLinkedList();

            Console.WriteLine(dlinkedlist.IsEmpty());

            dlinkedlist.Unshift(1);
            dlinkedlist.Unshift(0);
            dlinkedlist.Push(2);
            dlinkedlist.Push(3);
            dlinkedlist.AddBefore(0, -1);
            dlinkedlist.AddAfter(3, 4);

            dlinkedlist.GetAll();
        }
    }
}
