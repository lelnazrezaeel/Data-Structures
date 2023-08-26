using System;

namespace Tmrin2_1
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
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] order;
            string input;
            StackArr stack = new StackArr();
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            while ((input=Console.ReadLine())!="" && input!=null)
            {
                order = input.Split();
                switch (order[0])
                {
                    case "push":
                        stack.Push(int.Parse(order[1]));
                        break;
                    case "pop":
                        output.Append(stack.Pop().ToString()+"\n");
                        break;
                    case "peek":
                        output.Append(stack.Peek().ToString()+"\n");
                        break;
                    case "size":
                        output.Append(stack.Size().ToString()+"\n");
                        break;
                    case "isEmpty":
                        output.Append(stack.IsEmpty()+"\n");
                        break;
                }
            }

            Console.WriteLine($"{output}");
        }
    }
}
