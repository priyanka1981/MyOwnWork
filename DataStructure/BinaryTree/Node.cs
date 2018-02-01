using System;
using System.Collections.Generic;

namespace DataStructure.BinaryTree
{
    public class Node<T>
    {
        public Node()
        {
        }

        public Node(T _data)
        {
            this.data = _data;
        }


        public T data;
        public Node<T> LeftChild;
        public Node<T> RightChild;
        public Int16 height;
        public int depth;

        public T getValue()
        {
            return this.data;
        }

        public Node<T> getLeftChild(){
            return LeftChild;
        }

        public Node<T> getRightChild()
        {
            return RightChild;
        }
    }
}
