using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {

        }

        public void CreateSearchTree(int value)
        {
            Node newNode = new Node();
            Node current;
            //Node parentNode;
            newNode.number = value;
            bool haveAddedNewItem = false;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                current = root;     
                while (!haveAddedNewItem)
                {
                    if (value < current.number)
                    {
                        if(current.leftNode == null)
                        {
                            current.leftNode = newNode;
                            haveAddedNewItem = true;
                        }
                        else
                        {
                            current = current.leftNode;
                        }
                    }
                    else
                    {
                        if (current.rightNode == null)
                        {
                            current.rightNode = newNode;
                            haveAddedNewItem = true;
                        }
                        else
                        {
                            current = current.rightNode;
                        }
                    }
                }
            }

            //Console.WriteLine();
            //Console.ReadLine();
        }

        public void Search(int value)
        {
            Node currentNode;
            if (root.number == value)
            {
                DisplayNumber();
            }
            if (value < root.number)
            {
                while(value < root.number)
                {
                    currentNode = root.leftNode;
                    if (currentNode.number == value)
                    {
                      DisplayNumber();
                    }
                    else if (currentNode.number < value)
                    {
                        currentNode.leftNode = currentNode;
                    }
                    else if (currentNode.number > value)
                    {
                        currentNode.rightNode = currentNode;
                    }
                    else if (currentNode.number == null)
                    {
                        Console.WriteLine("404 Value Not Found");
                    }
                }
            }
            if (value > root.number)
            {
                while (value > root.number)
                {
                    currentNode = root.rightNode;
                    if (currentNode.number == value)
                    {
                        DisplayNumber();
                    }
                    else if (currentNode.number < value)
                    {
                        currentNode.leftNode = currentNode;
                    }
                    else if (currentNode.number > value)
                    {
                        currentNode.rightNode = currentNode;
                    }
                    else if (currentNode.number == null)
                    {
                        Console.WriteLine("404 Value Not Found");
                    }
                }
                
            }
        }

        public void DisplayNumber()
        {
            Console.WriteLine("This might be your number, not entirely sure though..");
        }

    }
}
