using System;
using System.Collections.Generic;

namespace DataStructure.LinkList
{
    public class Node<T>
    {
        public Node(Node<T> node)
        {
           
        }

        public Node(){}
   
        public Node<T> next;
        public T data;
    public Node(T _data, Node<T> node)
    {
            
        this.data = _data;
    }

    public Node(T _data)
    {
             
        this.data = _data;
    }

   
}
}
