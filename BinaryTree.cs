using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root { get; set; }
        public bool Add(int value)
        {
            Node before = null;
            Node after = this.root;
            while (after != null)
            {
                before = after;
                if (value < after.data)
                {
                    after = after.leftNode;
                }
                else if (value > after.data)
                {
                    after = after.rightNode;
                }
                else
                {
                    return false;
                }
            }
           Node newNode = new Node();
                newNode.data = value;
                if (this.root == null)
                {
                    this.root = newNode;
                }
                else
                {
                    if (value < before.data)
                    {
                        before.leftNode = newNode;
                    }
                    else
                    {
                        before.rightNode = newNode;
                    }
                }
            return true;
        }
        public void TraverseForPreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write("  "+parent.data+"  ");
                TraverseForPreOrder(parent.leftNode);
                TraverseForPreOrder(parent.rightNode);
            }

        }

        public void TraverseForInOrder(Node parent)
        {
            if (parent != null)
            {

                TraverseForInOrder(parent.leftNode);

                Console.Write("  "+parent.data+"  ");

                TraverseForInOrder(parent.rightNode);
            }

        }

        public void TraverseForPostOrder(Node parent)
        {
            if (parent != null)
            {

                TraverseForPostOrder(parent.leftNode);

                TraverseForPostOrder(parent.rightNode);

                Console.Write("  "+parent.data+"  ");
            }



        }
    }
}
