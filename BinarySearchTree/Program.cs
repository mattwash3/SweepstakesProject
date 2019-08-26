using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree searchTree = new BinarySearchTree();
            searchTree.CreateSearchTree(55);
            searchTree.CreateSearchTree(80);
            searchTree.CreateSearchTree(70);
            searchTree.CreateSearchTree(60);
            searchTree.CreateSearchTree(50);
            searchTree.CreateSearchTree(40);
            searchTree.CreateSearchTree(30);
            searchTree.Search(48);
            Console.ReadLine();
        }
    }
}
