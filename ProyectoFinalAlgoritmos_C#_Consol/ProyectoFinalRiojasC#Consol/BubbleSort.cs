public class BubbleSort
{
    public static void Sort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (array[i - 1] > array[i])
                {
                    // Swap the elements
                    int temp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = temp;

                    swapped = true;
                }
            }

            // Display the current state of the array
            DisplayArray(array);
        } while (swapped);
    }

    public static void DisplayArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
