using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Basic
{
    class ArrayAssignment15_4
    {
        static void Main(string[] args)
        {

           // Count the Number of Count of each alphabet and display the Min Count and Character

           // char[] arr = new char[] { 'c', 'c', 'c', 'b', 'b', 'a', 'd', 'b', 'e', 'd', 'b', 'b', 'a', 'e' };
           // char key, mincountkey = 'a';
           // int count, mincount = 10;
           // char[] arr2 = new char[10];
           // int flag, arrindex = 0;

           // for (int i = 0; i < arr.Length; i++)
           // {
           //     flag = 0;
           //     for (int k = 0; k < arr2.Length; k++)
           //     {
           //         if (arr2[k] == arr[i])
           //         {
           //             flag = 1;
           //             break;
           //         }
           //     }


           //     if (flag == 1)
           //         continue;
           //     else
           //     {
           //         arr2[arrindex] = arr[i];
           //         arrindex++;
           //         key = arr[i];
           //         count = 1;

           //         for (int j = i + 1; j < arr.Length; j++)
           //         {

           //             if (key == arr[j])
           //                 count++;

           //         }
           //         Console.WriteLine($"char={arr[i]}, count={count}");
           //         if (mincount > count)
           //         {
           //             mincountkey = key;
           //             mincount = count;
           //         }
           //     }


           // }
           // Console.WriteLine($"mincount key {mincountkey} min count = {mincount}");




           // Program to count the sum min and max of 3 * 3 array row


           // int[,] arr = new int[3, 3];
           // int min = 100, max = 0;
           // Console.WriteLine("Enter the 3*3 Array");
           // for (int i = 0; i < 3; i++)
           // {
           //     for (int j = 0; j < 3; j++)
           //     {
           //         arr[i, j] = Convert.ToInt32(Console.ReadLine());
           //     }
           // }

           // Console.WriteLine("***********************");
           // for (int i = 0; i < 3; i++)
           // {
           //     int sum = 0;
           //     for (int j = 0; j < 3; j++)
           //     {
           //         sum = sum + arr[i, j];
           //         if (j == 2)
           //         {
           //             Console.WriteLine("Sum of " + i + " th row =" + sum);
           //             if (sum > max)
           //                 max = sum;
           //             if (sum < min)
           //                 min = sum;
           //         }
           //     }
           // }
           // Console.WriteLine($"min= {min} max = {max}");



           // 7) Write a  program to remove duplicate elements from an array?
           //   Array With Duplicates: [4, 3, 2, 4, 9, 2]
           //   Array Without Duplicates: [4, 3, 2, 9]

           // int[] arr = new int[] { 4, 3, 2, 4, 9, 2, 3, 5, 6, 1 };
           // int[] arr2 = new int[10];
           // for (int i = 0; i < arr.Length; i++)
           // {
           //     if (arr[i] == 0)
           //         continue;
           //     for (int j = i + 1; j < arr.Length; j++)
           //     {
           //         if (arr[i] == arr[j])
           //             arr[j] = 0;
           //     }
           // }
           // int arrindex = 0;
           // for (int j = 0; j < arr.Length; j++)
           // {
           //     if (arr[j] != 0)
           //     {
           //         arr2[arrindex] = arr[j];
           //         arrindex++;
           //     }
           // }
           // for (int j = 0; arr2[j] != 0; j++)
           //     Console.WriteLine($"No = {arr2[j]}");




           // 1)  create a Array of integer and count the
           //  number of even and odd elements from array.


           //int[] arr = new int[] { 3, 5, 8, 23 };
           // int oddcount = 0, evencount = 0;
           // for (int i = 0; i < arr.Length; i++)
           // {
           //     if (arr[i] % 2 == 0)
           //         evencount++;
           //     else
           //         oddcount++;
           // }

           // Console.WriteLine($"Even Count= {evencount}, Odd Count= {oddcount}");




           // 6) Write a  program to separate zeros from non-zeros in an integer array?
           // Input Array: [12, 0, 7, 0, 8, 0, 3]
           // Input Array After moving zeros to end:
           // [12, 7, 8, 3, 0, 0, 0]


           // int[] arr = new int[] { 12, 0, 7, 0, 8, 0, 3 };
           // int temp;
           // int j = arr.Length;
           // for (int i = 0; i < arr.Length; i++)
           // {

           //     if (arr[i] != 0)
           //         continue;
           //     else
           //     {
           //         for (j = arr.Length - 1; j >= i; j--)
           //         {
           //             if (arr[j] != 0)
           //             {

           //                 temp = arr[i];
           //                 arr[i] = arr[j];
           //                 arr[j] = temp;
           //                 break;

           //             }
           //             else
           //                 continue;
           //         }
           //     }

           // }
           // foreach (int i in arr)
           //     Console.WriteLine(i);





        }
    }

}
