using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        Node root;
        
        public void CreateTree()
        {
            root = new Node(4);
        }
        public void LinkToRoot(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }
        //wrap around array
    }
}
