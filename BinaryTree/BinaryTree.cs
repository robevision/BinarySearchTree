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
        private Node temp;
        public BinaryTree()
        {
            root = null;
            
        }
        //public void CreateTree()
        //{
        //    //get user input for adding to root node
        //    int data = int.Parse(Console.ReadLine());
        //    if
        //    root = new Node(data);
        //}
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = root;
            root = temp;
        }
        public void InsertAtEnd(int data)
        {
            Node node;
            Node temp = new Node(data);
            if(root == null)
            {
                root = temp;
                return;
            }
            node = root;
            while(node.link != null)
            {
                node = node.link;
            }
            node.link = temp;
        }
        public void Add(int data)
        {
            Node temp = new Node(data);
            if(root == null)
            {
                InsertInBeginning(data);
            }
            else if (data < root.data)
            {
                temp = temp.right;
            }
            else if (data < root.data)
            {
                temp = temp.left;
            }
        }
      
        //wrap around array
    }
}
