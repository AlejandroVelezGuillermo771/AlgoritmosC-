// RadixSort.cs
using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class RadixSort
    {
        public static void Sort(int[] arr)
        {
            int max = GetMax(arr);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp);
                PrintArray(arr);
            }
        }

        private static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (var num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private static void CountingSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}