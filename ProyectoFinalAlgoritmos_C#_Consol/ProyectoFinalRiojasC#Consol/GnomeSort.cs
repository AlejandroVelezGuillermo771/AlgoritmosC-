// GnomeSort.cs
public class GnomeSort
{
    public static void Sort(int[] array)
    {
        int index = 0;

        while (index < array.Length)
        {
            if (index == 0 || array[index] >= array[index - 1])
            {
                index++;
            }
            else
            {
                // Swap elements if they are in the wrong order
                int temp = array[index];
                array[index] = array[index - 1];
                array[index - 1] = temp;

                // Move back to the previous position to check again
                index--;
            }
        }
    }
}