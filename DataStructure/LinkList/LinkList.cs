using System;
namespace DataStructure.LinkList
{
    public class LinkList
    {
        private Node head;
        private Node tail;
        private Node current;

        public LinkList()
        {
        }



        public void Add(Node node, int _data)
        {
            if (node.head != null)
                head = node;
            else
                current.next = node;
        }

    }
}
