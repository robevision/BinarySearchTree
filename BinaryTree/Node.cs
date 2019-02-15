using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node link;
        public Node(int data)
        {
            this.data = data;
            link = null;
            left = null;
            right = null;
        }
        public void Traverse()
        {
            if (left != null)
            {
                left.Traverse();
            }
            if (right != null)
            {
                right.Traverse();
            }
        }

    }
}
