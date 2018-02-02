using System;
using DataStructure.LinkList;
using DataStructure.BinaryTree;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            /*Link List
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
            */
            BinaryTree.BinaryTree<int> binaryTree = new DataStructure.BinaryTree.BinaryTree<int>();
            DataStructure.BinaryTree.Node<int> root = new DataStructure.BinaryTree.Node<int>(8);
            binaryTree.Add(root);
            DataStructure.BinaryTree.Node<int> node1 = new DataStructure.BinaryTree.Node<int>(6);
            DataStructure.BinaryTree.Node<int> node2 = new DataStructure.BinaryTree.Node<int>(10);
            DataStructure.BinaryTree.Node<int> node3 = new DataStructure.BinaryTree.Node<int>(5);
            DataStructure.BinaryTree.Node<int> node4 = new DataStructure.BinaryTree.Node<int>(7);
            DataStructure.BinaryTree.Node<int> node5 = new DataStructure.BinaryTree.Node<int>(9);
            DataStructure.BinaryTree.Node<int> node6 = new DataStructure.BinaryTree.Node<int>(12);
            DataStructure.BinaryTree.Node<int> node7 = new DataStructure.BinaryTree.Node<int>(13);
            binaryTree.addChild(node1);
            binaryTree.addChild(node2);
            binaryTree.addChild(node3);
            binaryTree.addChild(node4); 
            binaryTree.addChild(node5); 
            binaryTree.addChild(node6); 
            //Console.WriteLine("The Node is existing in a binary tree" + binaryTree.Search(root,node7)); 
            //Console.ReadKey();
            binaryTree.Inorder(root);
            binaryTree.BFS(root);
            Console.ReadKey();
        }

       
    }
}
