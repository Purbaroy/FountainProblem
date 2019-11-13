using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'fountainActivation' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int fountainActivation(List<int> arr)
    {
        
        int n = arr.Count();
        int[] interval = new int[n];
        int count = 1;
        for (int i = 1; i <= n; i++)
        {
            int left = Math.Max(i - arr[i - 1], 1);
            int right = Math.Min(i + arr[i - 1], n);

            interval[left - 1] = right;
        }

         int righto = interval[0];
        int currMax = righto;
        for (int i = 1; i < n; i++)
        {
            currMax = Math.Max(currMax, interval[i]);

            
            if (i == righto)
            {
                count++;
                righto = currMax;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int aCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = new List<int>();

        for (int i = 0; i < aCount; i++)
        {
            int aItem = Convert.ToInt32(Console.ReadLine().Trim());
            a.Add(aItem);
        }

        int result = Result.fountainActivation(a);

        Console.WriteLine(result);

    }
}
