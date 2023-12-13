using System;
using System.Collections.Generic;

public class SmoothSort
{
    private List<int> heap;

    public SmoothSort()
    {
        heap = new List<int>();
    }

    public void AddNumber(int number)
    {
        heap.Add(number);
        SiftUp(heap.Count - 1);
        DisplayHeap();
    }

    private void SiftUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (heap[index] < heap[parentIndex])
            {
                Swap(index, parentIndex);
                index = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    private void Swap(int i, int j)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    private void DisplayHeap()
    {
        Console.WriteLine("Current Heap: " + string.Join(", ", heap));
    }

    public void Sort()
    {
        int n = heap.Count;
        for (int i = n - 1; i > 0; i--)
        {
            Swap(0, i);
            SiftDown(0, i - 1);
        }
        Console.WriteLine("Sorted Array: " + string.Join(", ", heap));
    }

    private void SiftDown(int start, int end)
    {
        int root = start;
        while (root * 2 + 1 <= end)
        {
            int child = root * 2 + 1;
            int swap = root;
            if (heap[swap] < heap[child])
            {
                swap = child;
            }
            if (child + 1 <= end && heap[swap] < heap[child + 1])
            {
                swap = child + 1;
            }
            if (swap != root)
            {
                Swap(root, swap);
                root = swap;
            }
            else
            {
                break;
            }
        }
    }
}
