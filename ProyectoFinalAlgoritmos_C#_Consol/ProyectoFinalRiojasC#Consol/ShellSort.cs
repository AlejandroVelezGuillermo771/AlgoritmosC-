// ShellSort.cs
public class ShellSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        int gap;

        for (gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = arr[i];
                int j;

                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }

                arr[j] = temp;
            }
        }
    }
}
