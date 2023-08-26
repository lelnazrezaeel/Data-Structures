using System;

namespace Tamrin2_5
{
    class StackArr
    {
        char[] stack = new char[10000];
        int index = 0;
        public void Push(char add)
        {
            if (index == 5000)
                return;
            stack[index] = add;
            index++;
        }

        public char? Pop()
        {
            if (index == 0)
                return null;
            index--;
            return stack[index];
        }

        public int Size()
        {
            return index;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StackArr stack = new StackArr();
            string input = Console.ReadLine();
            char first ;
            int flag = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if(flag == 1)
                {
                    first = input[i];
                    if (first == '{')
                        stack.Push('}');
                    else if (first == '(')
                        stack.Push(')');
                    else if (first == '[')
                        stack.Push(']');
                    else if (first == '}' || first == ')' || first == ']')
                    {
                        if (stack.Pop() != first)
                        {
                            flag = 0;
                        }
                    }
                }
                
            }
            if (stack.Size() != 0)
                flag = 0;
            Console.WriteLine(flag);
        }
    }
}
