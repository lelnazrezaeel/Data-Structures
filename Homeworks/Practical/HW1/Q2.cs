using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1_1
{
    class Program
    {
        static string Reverse(string inp1)
        {
            string output="" ;
            for(int i=inp1.Length-1 ; i>=0 ; i--)
            {
                output += inp1[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            string inp1 = Console.ReadLine();
            string inp2 = Console.ReadLine();
            if (Reverse(inp1) == inp2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
