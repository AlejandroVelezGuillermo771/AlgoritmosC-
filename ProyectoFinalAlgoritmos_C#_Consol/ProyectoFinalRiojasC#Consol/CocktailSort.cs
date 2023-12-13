public class CocktailSort
{
    public static void Sort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }
}

