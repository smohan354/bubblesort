using System;

class BubbleSortExample
{
    static void Main(string[] args)
    {
        int[] bubble_sort_numbers = { 5, 72, 3, 14, 7, 1 };

        Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
        for (int i = 0; i < bubble_sort_numbers.Length; i++)
        {
            Console.Write("  " + bubble_sort_numbers[i]);
        }
        Console.WriteLine("");

        Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
        BubbleSort(bubble_sort_numbers);
        Console.WriteLine();
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        // Print sorted array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("  " + arr[i]);
        }
    }
}
