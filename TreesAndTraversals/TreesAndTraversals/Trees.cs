//You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1).
//Write a program to read the tree and find:

//a)the root node
//b)all leaf nodes
//c)all middle nodes
//d)the longest path in the tree
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesAndTraversals
{
    class Trees
    {
        static int n;
        static Node<int>[] nodes;

        static Node<int> FindRoot(Node<int>[] nodes)
        { 
            var hasParent = new bool[n];
            foreach (var node in nodes)
            {
                foreach (var child in node.children)
                {
                    hasParent[child.value] = true;
                }
            }
            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }
            throw new ArgumentException("There is no root.");
        }

        static List<Node<int>> FindLeafs(Node<int>[] nodes)
            {
            List<Node<int>> leafs = new List<Node<int>>();
            foreach (var node in nodes)
                {
                if (node.children.Count == 0)
                    {
                    leafs.Add(node);
                    }
                }
            return leafs;
            }

        static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
            {
            List<Node<int>> middleNodes = new List<Node<int>>();
            foreach (var node in nodes)
                {
                if (node.hasParent == true && node.children.Count != 0)
                    {
                    middleNodes.Add(node);
                    }
                }
            return middleNodes;
            }

        static int FindLongestPath(Node<int> Root)
            {
            if (Root.children.Count == 0)
                {
                return 0;
                }

            int maxPath = 0;
            foreach (var node in Root.children)
                {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
                }
            return maxPath + 1;
            }

        static void Main(string[] args)
        {
             n = int.Parse(Console.ReadLine());
             nodes = new Node<int>[n];
            for (int i = 0; i <= n-1; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= n-1; i++)
            {
                string couple = Console.ReadLine();
                string[] ParentAndChildren = couple.Split(' ');
                int parent = int.Parse(ParentAndChildren[0]);
                int child = int.Parse(ParentAndChildren[1]);
                nodes[parent].children.Add(nodes[child]);
                nodes[child].hasParent = true;

            }
            
            //find the root
            var root = FindRoot(nodes);
            Console.WriteLine("The root is {0}", root.value);

            //find the leafs
            var leafs = FindLeafs(nodes);
            Console.Write("Leafs are:");
            foreach (var leaf in leafs)
                {
                     Console.Write(leaf.value + ",");
                }
            Console.WriteLine();

            //find middle nodes
            var middleNodes = FindMiddleNodes(nodes);
            Console.Write("Middle nodes are:");
            foreach (var middleNode in middleNodes)
                {
                Console.Write(middleNode.value + ",");
                }
            Console.WriteLine();

            //find longest path
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.Write("The longest path is {0}", longestPath);
            
        }
    }
}
