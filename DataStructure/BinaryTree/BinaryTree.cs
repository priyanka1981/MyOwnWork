using System;
using System.Collections.Generic;
using DataStructure.BinaryTree;
namespace DataStructure.BinaryTree
{
    public class BinaryTree<T>
    {
        public BinaryTree()
        {
        }

        public DataStructure.BinaryTree.Node<T> root;

        public String addChild(Node<T> node)
        {
            node.height = 0;
            node.depth = 0;
            this.addChild(root, node);

            return "";
        }


        public void addChild(Node<T> node_1, Node<T> node)
        {
            if (Convert.ToInt16(node.getValue()) <=Convert.ToInt16(node_1.getValue()))
            {
                if (node_1.getLeftChild() != null)
                {
                    // REVISIT
                    // with every call to addChild on the left-node, root elements goes one level higher, and this node goes one down
                    root.height += 1;
                    //node_1.left_child.height += 1;
                    node.depth += 1;
                    addChild(node_1.getLeftChild(), node);
                }
                else
                {
                    node_1.LeftChild = node;


                }
            }
            else
            {
                if (node_1.getRightChild() != null)
                {
                    // REVISIT
                    // with every call to addChild on the right-node, root elements goes one level higher, and this node goes one down
                    root.height += 1;
                    node_1.LeftChild.height += 1;
                    node.depth += 1;
                    addChild(node_1.getRightChild(), node);
                }
                else
                {
                    node_1.RightChild = node;


                }
            }

            return;
        }


        public void Add(Node<T> node){
            Node<T> temp = new Node<T>();
            temp = root;
            if (root == null)
                root = node;
            else
            {
                if (Convert.ToInt16(node.getValue()) <= Convert.ToInt16(root.getValue()))
                {
                    //temp = null;
                    if (root.LeftChild == null)
                        root.LeftChild = node;
                    else if (Convert.ToInt16(node.getValue()) <= Convert.ToInt16(temp.getValue()))
                    {
                        //if(temp.)
                       // else
                            temp = temp.LeftChild.RightChild;
                        
                    }
                    else
                    {
                        while (temp.RightChild != null)
                        {
                            temp = temp.RightChild;
                        }
                        temp.RightChild = node;
                    }
                        
                }
                else
                {
                    //temp = null;
                    if (root.RightChild == null)
                        root.RightChild = node;
                    else
                    {
                        while (temp.RightChild != null)
                        {
                            temp = temp.RightChild;
                        }
                        temp.RightChild = node;
                    }

                }

            }
        }
    }
}
