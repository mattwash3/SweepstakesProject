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
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(80);
            tree.Add(70);
            tree.Add(60);
            tree.Add(50);
            tree.Add(40);
            tree.Add(30);
        }
    }
}
