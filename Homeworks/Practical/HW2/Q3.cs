using System;
using System.Text;

namespace Tamrin2_3
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
            for (int i=0 ; i<index - 1 ; i++)
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
            for (int i=0; i<del - 1 ; i++)
            {
                here = here.next;
            }
            here.next = here.next.next;
        }
        public int IndexOf(string key)
        {
            Node here = first;
            int s = 0;
            while(here != null)
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
            while(here != null)
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
            string[] order;
            string input;
            StringBuilder output = new StringBuilder();
            SLL sLL = new SLL();
            while((input=Console.ReadLine())!="" && input!=null)
            {
                order = input.Split();
                switch(order[0])
                {
                    case "add":
                        sLL.Add(order[1]);
                        break;
                    case "append":
                        sLL.Append(order[1]);
                        break;
                    case "insert":
                        sLL.Insert(int.Parse(order[1]), order[2]);
                        break;
                    case "delete":
                        sLL.Delete(int.Parse(order[1]));
                        break;
                    case "indexOf":
                        output.Append(sLL.IndexOf(order[1]).ToString() + "\n");
                        break;
                    case "printSLL":
                        output.Append(sLL.PrintSLL().ToString() + "\n");
                        break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
