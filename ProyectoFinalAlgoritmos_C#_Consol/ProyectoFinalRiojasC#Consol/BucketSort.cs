// BucketSort.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class BucketSort
{
    public static List<int> Sort(List<int> input)
    {
        if (input == null || input.Count <= 1)
        {
            return input;
        }

        int maxValue = input.Max();
        int minValue = input.Min();
        int bucketCount = maxValue - minValue + 1;
        List<int>[] buckets = new List<int>[bucketCount];

        for (int i = 0; i < bucketCount; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach (int num in input)
        {
            buckets[num - minValue].Add(num);
        }

        List<int> result = new List<int>();

        foreach (List<int> bucket in buckets)
        {
            if (bucket.Count > 0)
            {
                bucket.Sort();
                result.AddRange(bucket);
            }
        }

        return result;
    }
}
