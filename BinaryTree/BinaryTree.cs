using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void Add(int data)
        {
            Node node;
            Node temp = new Node(data);

            if (root == null)
            {
                root = temp;
                return;
            }
            node = root;
            while (node != null)
            {

                if (temp.data < node.data)
                {
                    //node = node.left;

                    if (node.left != null)
                    {
                        node = node.left;

                    }
                    else
                    {
                        node.left = temp;

                        return;
                    }
                }
                if (temp.data >= node.data)
                {

                    if (node.right != null)
                    {

                        node = node.right;


                    }
                    else
                    {
                        node.right = temp;

                        return;
                    }
                }
            }

        }

        public void Search(int data)
        {
            Node node;
            Node temp = new Node(data);

            if (root == null)
            {
                Console.WriteLine(root);
                Thread.Sleep(2000);
                root = temp;
                return;
            }
            node = root;
            while (node != null)
            {

                if (temp.data < node.data)
                {
                    if(temp.data == node.data)
                    {
                        Console.WriteLine(node.data);
                        Thread.Sleep(2000);
                    }
                    //node = node.left;

                    if (node.left != null)
                    {
                        node = node.left;

                    }
                    else
                    {
                        node.left = temp;

                        return;
                    }
                }
                if (temp.data >= node.data)
                {
                    if(temp.data == node.data)
                    {
                        Console.WriteLine(node.data);
                        Thread.Sleep(2000);
                    }

                    if (node.right != null)
                    {

                        node = node.right;


                    }
                    else
                    {
                        node.right = temp;

                        return;
                    }
                }
            }

        }

    }
        //    //wrap around array
        //}
    }
