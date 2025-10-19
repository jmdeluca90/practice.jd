using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.Helpers
{
    public class Heap
    {
        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;          // assume parent is largest
            int left = 2 * i + 1;       // left child
            int right = 2 * i + 2;      // right child

            // if left child exists and is bigger
            if (left < n && arr[left] > arr[largest])
                largest = left;

            // if right child exists and is bigger
            if (right < n && arr[right] > arr[largest])
                largest = right;

            // if parent wasn’t actually the biggest, swap
            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);   // recursively heapify the affected subtree
            }
        }
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Step 1: Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Step 2: Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root (max) to end
                (arr[0], arr[i]) = (arr[i], arr[0]);

                // Heapify the reduced heap
                Heapify(arr, i, 0);
            }
        }
    }
}
