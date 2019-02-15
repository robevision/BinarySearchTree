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
            if(root == null)
            {
                InsertInBeginning(data);
            }
            if(temp.left!= null)
            {
                if (data < root.data)
                {
                    temp = temp.left;
                }
                if (data >= root.data)
                {
                    temp = temp.right;
                }
            }
            if (temp.right != null)
            {
                if (data < root.data)
                {
                    temp = temp.left;
                }
                else if (data >= root.data)
                {
                    temp = temp.right;
                }
                else
                {
                 
                }
            }
            Add(data);
            
        }
      
        //wrap around array
    }
}
