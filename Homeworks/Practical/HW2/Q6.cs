using System;

namespace Tamrin2_6
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
            string input = Console.ReadLine();
            string[] abs = new string[]
            StackArr stack = new StackArr();
            foreach (var i in input)
            {
                stack.Push(i);
            }
        }
    }
}
