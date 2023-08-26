using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string inp = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < inp.Length - 1  ; i++)
            {
                count = 1;
                if(inp[i] == inp[i+1])
                {  
                    if(inp.Length - i > 6)
                    {
                        for (int j = 1; j < 7; j++)
                        {
                            if (inp[i] == inp[i + j])
                                count++;
                        }
                    }
                    if (count == 7)
                    {
                        Console.WriteLine("YES");
                        flag = true;
                        break;
                    }
                }
            }
            if (flag == false)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
