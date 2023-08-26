using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = int.Parse(Console.ReadLine());
            int[] space = new int[col];
            int temp;
            string[] inp = Console.ReadLine().Split();
            for(int i=0; i<col; i++)
            {
                space[i] = int.Parse(inp[i].ToString());
            }
            for (int i=0; i<col-1 ; i++)
            {
                for (int j=0; j<col - 1 ; j++)
                {
                    if (space[j] > space[j+1])
                    {
                        temp = space[j];
                        space[j] = space[j+1];
                        space[j+1] = temp;
                    }
                }
            }
            for (int i = 0; i < col; i++)
            {
                Console.Write($"{space[i]} ");
            }
        }
    }
}
