// SelectionSort.cs
public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap arr[i] and arr[minIndex]
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;

            // Mostrar el paso actual
            ArrayHelper.DisplayArray(arr);
        }
    }
}
