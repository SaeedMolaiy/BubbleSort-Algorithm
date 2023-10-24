int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("Original Array:");
PrintArray(arr);

BubbleSort.BubbleSort.BubbleSortArray(arr);

Console.WriteLine("\nSorted Array:");
PrintArray(arr);

static void PrintArray(IEnumerable<int> arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }

    Console.WriteLine();
}