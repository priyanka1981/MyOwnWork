using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructure.LinkList
{
    public class LinkList<T>
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

        public void find(){
            
        }
       
        public void Delete(Node<T> node_to_delete)
        {
            if (head == null) return;
            else if(Convert.ToInt16(head.data) == Convert.ToInt16(node_to_delete.data))
            {
                
                Node<T> temp = new Node<T>();
                temp = head;
                head = head.next;
            }
            else{
                Node<T> temp = head;
                Node<T> previous = new Node<T>();
                while(temp.next !=null){
                    if (Convert.ToInt16(temp.next.data) == Convert.ToInt16(node_to_delete.data))
                    {
                        temp.next = temp.next.next;
                        return;
                    }
                    
                    else
                        temp = temp.next;
                }
            }
        }


    }
}
