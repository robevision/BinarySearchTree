using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(85);
            binaryTree.Add(74);
            binaryTree.Add(96);
            binaryTree.Add(105);
            binaryTree.Add(42);
            binaryTree.Add(31);
            binaryTree.Add(58);
            binaryTree.Add(12);
            binaryTree.Add(150);
            binaryTree.Add(76);
            binaryTree.Add(12);
            binaryTree.Search(150);
        }
    }
}
