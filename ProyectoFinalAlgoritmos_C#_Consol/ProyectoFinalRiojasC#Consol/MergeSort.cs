// MergeSort.cs
using System;

public class MergeSort
{
    public static void Sort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        Array.Copy(array, 0, left, 0, middle);
        Array.Copy(array, middle, right, 0, array.Length - middle);

        Sort(left);
        Sort(right);

        Merge(array, left, right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] < right[rightIndex])
            {
                array[mergedIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = right[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < left.Length)
        {
            array[mergedIndex] = left[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < right.Length)
        {
            array[mergedIndex] = right[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }
}
