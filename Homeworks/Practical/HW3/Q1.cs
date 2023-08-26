using System;

namespace Tamrin3_1
{
    class Node
    {
        public Node Left{ get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
    }
    class BST
    {
        public Node Root { get; set; }

        public int Insert(int key)
        {
            Node before = null;
            Node after = this.Root;
            while (after != null)
            {
                before = after;
                if (key < after.Data) 
                    after = after.Left;
                else if (key >= after.Data)
                    after = after.Right;
            }

            Node newNode = new Node();
            newNode.Data = key;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (key < before.Data)
                    before.Left = newNode;
                else
                    before.Right = newNode;
            }

            return key;
        }

        public bool Delete(int del)
        {
            if(Search(del) == false)
            {
                return false;
            }
            this.Root = Remove(this.Root, del);
            return true;
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null) 
                return parent;
            if (key < parent.Data) 
                parent.Left = Remove(parent.Left, key);
            else if (key > parent.Data)
                parent.Right = Remove(parent.Right, key);
            else
            {
                if (parent.Left == null)
                    return parent.Right;
                else if (parent.Right == null)
                    return parent.Left;
                parent.Data = GetMin(parent.Right);
                parent.Right = Remove(parent.Right, parent.Data);
            }
            return parent;
        }
        public bool Search(int key)
        {
            Node search = this.Find(key, this.Root);
            return (search != null);
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(value, parent.Left);
                else
                    return Find(value, parent.Right);
            }

            return null;
        }

        public int GetMin(Node node)
        {
            int minv = node.Data;

            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }
            return minv;
        }

        public int GetMax(Node node)
        {
            int maxv = node.Data;

            while (node.Right != null)
            {
                maxv = node.Right.Data;
                node = node.Right;
            }
            return maxv;
        }
        public void PreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                PreOrder(parent.Left);
                PreOrder(parent.Right);
            }
        }

        public void InOrder(Node parent)
        {
            if (parent != null)
            {
                InOrder(parent.Left);
                Console.Write(parent.Data + " ");
                InOrder(parent.Right);
            }
        }

        public void PostOrder(Node parent)
        {
            if (parent != null)
            {
                PostOrder(parent.Left);
                PostOrder(parent.Right);
                Console.Write(parent.Data + " ");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] values = new int[n];
            BST binarySearchTree = new BST();
            for (int i = 0; i < n; i++)
            {
                values[i] = int.Parse(input[i]);
                binarySearchTree.Insert(values[i]);
            }
            int m = int.Parse(Console.ReadLine());
            string[] cop = new string[2];
            string[] order = new string[m];
            int[] key = new int[m];
            for (int i = 0; i < m; i++)
            {
                cop = Console.ReadLine().Split();
                order[i] = cop[0];
                if (order[i] == "insert" || order[i] == "delete" || order[i] == "search")
                {
                    key[i] = int.Parse(cop[1]);
                }
            }
            for(int i=0; i<m; i++)
            {    
                switch(order[i])
                {
                    case "insert":
                        Console.WriteLine(binarySearchTree.Insert(key[i]).ToString());
                        break;
                    case "delete":
                        Console.WriteLine(binarySearchTree.Delete(key[i]).ToString());
                        break;
                    case "search":
                        Console.WriteLine(binarySearchTree.Search(key[i]).ToString());
                        break;
                    case "getmin":
                        Console.WriteLine(binarySearchTree.GetMin(binarySearchTree.Root).ToString());
                        break;
                    case "getmax":
                        Console.WriteLine(binarySearchTree.GetMax(binarySearchTree.Root).ToString());
                        break;
                    case "preorder":
                        binarySearchTree.PreOrder(binarySearchTree.Root);
                        Console.WriteLine();
                        break;
                    case "inorder":
                        binarySearchTree.InOrder(binarySearchTree.Root);
                        Console.WriteLine();
                        break;
                    case "postorder":
                        binarySearchTree.PostOrder(binarySearchTree.Root);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
