using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndTraversals
{
    public class Node<T>
    {
        public T value { get; set; }
        public List<Node<T>> children { get; set; }
        public bool hasParent { get; set; }

        public Node()
        {
            this.children = new List<Node<T>>();
        }

        public Node(T Value) : this()
        {
            this.value = Value;
        }
    }
}
