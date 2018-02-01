using System;
using DataStructure.LinkList;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            LinkList<int> linklist = new LinkList<int>();
            Node<int> head = new Node<int>(1);
            //linklist.head = head;
            linklist.Add(head);
            Node<int> node2 = new Node<int>(2);
            linklist.Add(node2);
            Node<int> node3 = new Node<int>(3);
            linklist.Add(node3);
            Node<int> node4 = new Node<int>(4);
            linklist.Add(node4);
            linklist.Delete(node3);

        }

       
    }
}
