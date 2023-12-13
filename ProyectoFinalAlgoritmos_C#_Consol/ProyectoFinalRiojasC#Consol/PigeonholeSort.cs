// PigeonholeSort.cs
using System;

public class PigeonholeSort
{
    public static void Sort(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        int range, i, j, index;

        for (int a = 0; a < arr.Length; a++)
        {
            if (arr[a] > max)
            {
                max = arr[a];
            }
            if (arr[a] < min)
            {
                min = arr[a];
            }
        }

        range = max - min + 1;
        int[] pigeonhole = new int[range];

        for (i = 0; i < arr.Length; i++)
        {
            pigeonhole[arr[i] - min]++;
        }

        index = 0;

        for (j = 0; j < range; j++)
        {
            while (pigeonhole[j]-- > 0)
            {
                arr[index++] = j + min;
            }
        }
    }
}