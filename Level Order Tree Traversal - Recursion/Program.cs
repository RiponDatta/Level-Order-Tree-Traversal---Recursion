using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_Order_Tree_Traversal___Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Right = new Node(7);
            tree.Root.Right.Right.Right = new Node(15);

            tree.PrintLevelOrder();
        }
    }
}
