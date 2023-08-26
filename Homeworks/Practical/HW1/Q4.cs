using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int laternsNum ;
            double len;
            double maxD, minD , maxF , disD;
            string[] inp1 = new string[2];
            inp1 = Console.ReadLine().Split();
            len = double.Parse(inp1[1]);
            laternsNum = int.Parse(inp1[0]);
            string[] inp2 = new string[laternsNum];
            List<double> coordinate = new List<double>();
            inp2 = Console.ReadLine().Split();
            for(int i = 0; i< laternsNum; i++)
            {
                coordinate.Add(double.Parse(inp2[i]));
            }
            minD = coordinate.Min();
            maxD = len - coordinate.Max();
            if (maxD > minD)
                maxF = maxD;
            else
                maxF = minD;
            coordinate.Sort();
            double[] distance = new double[laternsNum - 1];
            for (int i = 0; i < laternsNum - 1 ; i++)
            {
                distance[i] = coordinate[i + 1] - coordinate[i];
                if (distance[i]/2 > maxF)
                    maxF = distance[i]/2;
            }
            disD = maxF;
            Console.WriteLine(disD.ToString("F10"));
        }
    }
}
