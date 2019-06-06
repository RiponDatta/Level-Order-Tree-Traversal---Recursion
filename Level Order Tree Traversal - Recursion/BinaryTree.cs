using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_Order_Tree_Traversal___Recursion
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void PrintLevelOrder()
        {
            int h = Height(Root);
            for(int i = 1; i <= h; i++)
            {
                PrintGivenLevel(Root, i);
                Console.WriteLine();
            }            
        }

        private void PrintGivenLevel(Node root, int level)
        {
            if(root == null)
            {
                return;
            }
            if(level == 1)
            {
                Console.Write(root.Data + " ");
            }
            else if(level > 1)
            {
                PrintGivenLevel(root.Left, level - 1);
                PrintGivenLevel(root.Right, level - 1);
            }
        }

        private int Height(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            var leftHeight = Height(root.Left);
            var rightHeight = Height(root.Right);

            if(leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            return rightHeight + 1;
        }
    }
}
