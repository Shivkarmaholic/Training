using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class LongestSubArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 0, 1, 0, 1, 1, 0, 0 };
            int ones = 0, zeros = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zeros = 0;
                ones = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zeros++;
                    else
                        ones++;
                    if (ones == zeros)
                    {
                        if (max < (j - i + 1))
                            max = j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
