using System;

namespace Tamrin2_2
{
    public class Queue
    {
        int index = 0;
        int[] queue = new int[10000];

        public void Enqueue(int add)
        {
            queue[index] = add;
            index++;
        }

        public int Dequeue()
        {
            int deq = queue[0];
            for (int i = 0; i < index - 1 ; i++)
            {
                queue[i] = queue[i + 1];
            }
            index--;
            return deq;
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
            Queue queue = new Queue();
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            string input;
            while((input = Console.ReadLine())!="" && input!=null)
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
