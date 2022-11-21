using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMRSchemeTalk
{
    internal class Node<T>
    {
        public int Val = 1;
        public int Height = 1;
        public Node<T> Right = new Node<T>(default, default, 0);
        public Node<T> Left = new Node<T>(default, default, 0);

        public Node(Node<T> right, Node<T> left, int height)
        {
            Height = height;
            Right = right;
            Left = left;
        }

    }
}
