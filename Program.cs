using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(56);
            tree.Add(30);
            tree.Add(22);
            tree.Add(40);
            tree.Add(11);
            tree.Add(16);
            tree.Add(3);
            tree.Add(70);
            tree.Add(60);
            tree.Add(95);
            tree.Add(65);
            tree.Add(63);
            tree.Add(67);

            tree.TraverseForPreOrder(tree.root);
            Console.WriteLine();

            tree.TraverseForInOrder(tree.root);
            Console.WriteLine();

            tree.TraverseForPostOrder(tree.root);

            Console.ReadLine();



        }
    }
}
