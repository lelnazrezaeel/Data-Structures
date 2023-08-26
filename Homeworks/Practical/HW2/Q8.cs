using System;
using System.Text;

namespace Tamrin2_8
{
    class Node
    {
        public string value;
        public Node next;
        public Node(string v)
        {
            value = v;
            next = null;
        }
    }
    class SLL
    {
        Node first = null;

        public void Add(string addFirst)
        {
            Node firstNode = new Node(addFirst);
            firstNode.next = first;
            first = firstNode;
        }
        public void Append(string addLast)
        {
            Node lastNode = new Node(addLast);
            Node here = first;
            if (here == null)
            {
                first = lastNode;
                return;
            }
            while (here.next != null)
                here = here.next;
            here.next = lastNode;
        }
        public void Insert(int index, string insert)
        {
            Node insertNode = new Node(insert);
            Node here = first;
            if (index == 0)
            {
                Add(insert);
                return;
            }
            for (int i = 0; i < index - 1; i++)
            {
                here = here.next;
            }
            insertNode.next = here.next;
            here.next = insertNode;
        }
        public void Delete(int del)
        {
            Node here = first;
            if (del == 0)
            {
                first = first.next;
                return;
            }
            for (int i = 0; i < del - 1; i++)
            {
                here = here.next;
            }
            here.next = here.next.next;
        }
        public int IndexOf(string key)
        {
            Node here = first;
            int s = 0;
            while (here != null)
            {
                if (here.value == key)
                {
                    break;
                }
                s++;
                here = here.next;
            }
            return s;
        }
        public string PrintSLL()
        {
            StringBuilder output = new StringBuilder();
            Node here = first;
            while (here != null)
            {
                output.Append(here.value + " ");
                here = here.next;
            }
            return output.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SLL sLL0 = new SLL();
            SLL sLL1 = new SLL();
            SLL sLL2 = new SLL();
            string[] input = Console.ReadLine().Split();
            string[] indexes = Console.ReadLine().Split();
            int m = int.Parse(indexes[0]);
            int n = int.Parse(indexes[1]);
            for (int i = 0; i < m; i++)
                sLL0.Append(input[i]);
            for (int i = m; i <= n; i++)
                sLL1.Add(input[i]);
            for (int i = n + 1; i < input.Length; i++)
                sLL2.Append(input[i]);
            Console.WriteLine(sLL0.PrintSLL() + sLL1.PrintSLL() + sLL2.PrintSLL());
        }
    }
}
