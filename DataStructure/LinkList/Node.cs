using System;
namespace DataStructure.LinkList
{
    public class Node
    {
        public Node(Node node)
        {
           
        }

    
    private int data;
    public Node current;
    public Node head;
    public Node tail;
    public Node next;
    public Node(int _data, Node node)
    {
            
        this.data = _data;
    }

    public Node(int _data)
    {
             
        this.data = _data;
    }

    public void Add(Node node, int _data)
    {
        if (head != null)
            head = node;
        else
            current.next = node;
    }
}
}
