using System;

public class CountingSort
{
    public static int[] Sort(int[] array)
    {
        int max = FindMax(array);

        // Inicializar el arreglo de recuento y el arreglo de salida
        int[] count = new int[max + 1];
        int[] sortedArray = new int[array.Length];

        // Contar la frecuencia de cada elemento
        foreach (int num in array)
        {
            count[num]++;
        }

        // Actualizar el arreglo de recuento para almacenar la posición real de cada elemento
        for (int i = 1; i <= max; i++)
        {
            count[i] += count[i - 1];
        }

        // Construir el arreglo ordenado
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int num = array[i];
            sortedArray[count[num] - 1] = num;
            count[num]--;
        }

        return sortedArray;
    }

    private static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
