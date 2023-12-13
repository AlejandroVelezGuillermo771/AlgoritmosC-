using System;

namespace SortingAlgorithms
{
    public class CombSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;
            int gap = n;
            const double shrink = 1.3;
            bool swapped;

            do
            {
                gap = (int)(gap / shrink);

                if (gap < 1)
                {
                    gap = 1;
                }

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    int j = i + gap;

                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                        swapped = true;
                    }
                }
            } while (gap > 1 || swapped);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
