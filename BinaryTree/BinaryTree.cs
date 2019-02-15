using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node root;
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
        //public void InsertInBeginning(int data)
        //{
        //    Node temp = new Node(data);
        //    temp = root;
        //    root = temp;
        //}
        //public void InsertForLeft(int data)
        //{
        //    root.temp = root;
        //    Node temp = new Node(data);
        //    temp.link = root;

        //    //get Object exception here!!!
        //    root.left = temp;
        //}
        //public void InsertForRight(int data)
        //{
        //    Node temp = new Node(data);
        //    root = temp.link;
        //    temp.link = root;
        //    root.right = temp;
        //}
        //public void InsertAtEnd(int data)
        //{
        //    Node temp = new Node(data);

        //    if (root == null)
        //    {
        //        root = temp;
        //        return;
        //    }
        //    //node = root;
        //    //while(node.link != null)
        //    //{
        //    //    node = node.link;
        //    //}
        //    //node.link = temp;
        //}
            public void Add(int data)    
        {
            Node temp = new Node(data);

            if (root == null)
            {
                root = temp;
                //InsertInBeginning(data);
                return;
            }
            while (root != null)
            {
               
                if (data < root.data)
                {
                    Node node = root.left;

                    if (node != null)
                    {
                        node.left = temp;
                        return;
                    }
                    else
                    {
                        root.left = temp;
                        
                        return;
                    }
                }
                if (data >= root.data)
                {
                    Node node = root.right;
                    if (node != null)
                    {

                        node.right = temp;
                        return;
                      
                    }
                    else
                    {
                        root.right = temp;
                        
                        return;
                    }
                }
            }
            
        }
        public void Search(int data)
        {
            Node temp = new Node(data);

            if (root == null)
            {
                root = temp;
               
                return;
            }
            while (root != null)
            {

                if (data < root.data)
                {
                    Node node = root.left;

                    if (node != null)
                    {
                        node.left = temp;
                        return;
                    }
                    else
                    {
                        root.left = temp;

                        return;
                    }
                }
                if (data >= root.data)
                {
                    Node node = root.right;
                    if (node != null)
                    {

                        node.right = temp;
                        return;

                    }
                    else
                    {
                        root.right = temp;

                        return;
                    }
                }
            }

        }


        //wrap around array
    }
}
