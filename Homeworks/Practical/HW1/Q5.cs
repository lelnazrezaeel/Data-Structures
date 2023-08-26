using System;
using System.Collections.Generic;

namespace Tamrin1_5
{
    class Program
    {
        enum orders { SORT , IS_SORTED ,GETMAX , APPEND , GET_HISTOGRAM }
        static List<int> Sort (List<int> arr , string flag)
        {
            int len = arr.Count;
            for (int i = 1; i < len; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                if (flag == "DESCENDING")
                {
                    while (j >= 0 && arr[j] < key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                }
                else
                {
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                }               
                arr[j + 1] = key;
            }
            return arr;
        }
        static string outputForm(List<int> arr)
        {
            string output = "";
            for (int i = 0; i < arr.Count; i++)
            {
                output += arr[i].ToString() + " ";
            }
            return output;
        }
        static bool isSorted (List<int> arr, string flag)
        {
            bool check = true;
            if (flag == "DESCENDING")
            {
                for (int i = 0; i < arr.Count-1; i++)
                { 
                    if(arr[i]<arr[i+1])
                    {
                        check = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Count-1; i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }
        static List<int> Histogram (List<int>arr ,int n)
        {
            List<int> hist = Sort(arr," ");
            int[] count = new int[n]; 
            List<int> p = new List<int>();
            double min = hist[0];
            double max = hist[arr.Count-1];
            double len = (double)(max - min) / n;
            double lenght = Math.Ceiling(len);
            double b = lenght + min;
            for (int j = 0; j < n; j++)
            {
                for (double i = min; i < b; i++)
                {
                    for (int k = 0; k < hist.Count; k++)
                    {
                        if (i == hist[k])
                        {
                            count[j]++;
                        }
                    }
                }
                min = b;
                b = min + lenght;
            }
            for(int i=0; i<n; i++)
            {
                p.Add(count[i]);
            }
            return p;
           
        }
        static int GetMax(List<int> arr)
        {
            int max = arr[0];
            for(int i=1; i<arr.Count; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static List<int> Append(List<int> arr , int key)
        {
            List<int> output = new List<int>();
            int flag = 0;
            if(arr[0]>=arr[arr.Count-1])
            {
                flag = 1;
            }
            else
            {
                flag = 0;
            }
            if (flag == 1)
            {
                if(key>=arr[0])
                {
                    output.Add(key);
                    for(int i=0; i<=arr.Count-1; i++)
                    {
                        output.Add(arr[i]);
                    }
                }
                else if(key<=arr[arr.Count-1])
                {
                    for (int i = 0; i <= arr.Count - 1; i++)
                    {
                        output.Add(arr[i]);
                    }
                    output.Add(key);
                }
                else
                {
                    for (int i = 0; i < arr.Count - 1; i++)
                    {
                        if(arr[i]>=key && key>arr[i+1])
                        {
                            output.Add(key);
                        }
                        output.Add(arr[i]);
                    }
                    output.Add(arr[arr.Count-1]);
                }
            }
            else
            {
                if (key <= arr[0])
                {
                    output.Add(key);
                    for (int i = 0; i <= arr.Count - 1; i++)
                    {
                        output.Add(arr[i]);
                    }
                }
                else if (key >= arr[arr.Count-1])
                {
                    for (int i = 0; i <= arr.Count - 1; i++)
                    {
                        output.Add(arr[i]);
                    }
                    output.Add(key);
                }
                else
                {
                    for (int i = 0; i < arr.Count - 1; i++)
                    {
                        if (arr[i] <= key && key < arr[i + 1])
                        {
                            output.Add(key);
                        }
                        output.Add(arr[i]);
                    }
                    output.Add(arr[arr.Count-1]);
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            orders order;
            string[] input1 = new string[2];
            string output = "";
            for (int i = 0; i < n; i++)
            {
                string flag = "";
                input1 = Console.ReadLine().Split();
                order = (orders)Enum.Parse(typeof(orders), input1[0]);
                if (input1.Length == 2)
                {
                    flag = input1[1];
                }
                string[] input2 = Console.ReadLine().Split();
                List<int> nums = new List<int>();
                for (int j = 0; j < input2.Length; j++)
                {
                    nums.Add(int.Parse(input2[j]));
                }
                if (order == orders.SORT)
                {
                    if (flag == "DESCENDING")
                    {
                        output += outputForm(Sort(nums, flag)) + "\n";
                    }
                    else
                    {
                        output += outputForm(Sort(nums, flag)) + "\n";
                    }
                }
                else if (order == orders.IS_SORTED)
                {
                    if(isSorted(nums,flag) == true)
                    {
                        output += "YES\n";
                    }
                    else
                    {
                        output += "NO\n";
                    }
                }
                else if (order == orders.GETMAX)
                {
                    output += GetMax(nums).ToString() + "\n";
                }
                else if (order == orders.GET_HISTOGRAM)
                {
                    output += outputForm(Histogram(nums, int.Parse(flag))) + "\n";
                }
                else if (order == orders.APPEND)
                { 
                    output += outputForm(Append(nums,int.Parse(flag))) + "\n";
                }
            }
            Console.WriteLine(output);
        }
    }
}
