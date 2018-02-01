using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructure.LinkList
{
    public class LinkList<T>:IEnumerable<T>
    {
        public Node<T> head;
        public Node<T> tail;
       

        public LinkList()
        {
        }



        public void Add(Node<T> node)
        {
            if (head == null)
            {
                head = node;

            }
            else
            {
                tail.next = node;
            }
            tail = node;
        }


       // IEnumerator<T> IEnumerable<T>.GetEnumerator()
       


    }
}
