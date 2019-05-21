using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.data = value;
            bool haveAddedNewItem = false;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;     
                while (!haveAddedNewItem)
                {
                    if (value < current.data)
                    {
                        if(current.left == null)
                        {
                            current.left = newNode;
                            haveAddedNewItem = true;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = newNode;
                            haveAddedNewItem = true;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
            }
        }

        public void Search()
        {

        }

    }





}
