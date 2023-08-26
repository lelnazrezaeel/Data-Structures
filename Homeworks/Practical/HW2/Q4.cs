using System;

namespace Tamrin2_4
{
    class StackArr
    {
        int[] stack = new int[5000];
        int index = 0;
        public void Push(int add)
        {
            stack[index] = add;
            index++;
        }

        public int Pop()
        {
            index--;
            return stack[index];
        }

        public int Peek()
        {
            return stack[index - 1];
        }

        public int Size()
        {
            return index;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }
    }
    public class Queue
    {
        StackArr stack1 = new StackArr();
        StackArr stack2 = new StackArr();
        public void Enqueue(int add)
        {
            while(stack1.Size()!=0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(add);
            while (stack2.Size() != 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        public int Dequeue()
        {
            int del = stack1.Peek();
            stack1.Pop();
            return del;
        }

        public int Size()
        {
            return stack1.Size() + stack2.Size();
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] order;
            Queue queue = new Queue();
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "" && input != null)
            {
                order = input.Split();
                switch (order[0])
                {
                    case "enqueue":
                        queue.Enqueue(int.Parse(order[1]));
                        break;
                    case "dequeue":
                        output.Append(queue.Dequeue().ToString() + "\n");
                        break;
                    case "size":
                        output.Append(queue.Size().ToString() + "\n");
                        break;
                    case "isEmpty":
                        output.Append(queue.IsEmpty().ToString() + "\n");
                        break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
