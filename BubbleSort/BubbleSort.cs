namespace BubbleSort;

internal class BubbleSort
{
    public static void BubbleSortArray(int[] arr)
    {
        var n = arr.Length;

        for (var i = 0; i < n - 1; i++)
        {
            var swapped = false;

            for (var j = 0; j < n - i - 1; j++)
            {
                if (arr[j] <= arr[j + 1])
                {
                    continue;
                }

                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                swapped = true;
            }

            if (!swapped)
                break;

            for (var k = n - i - 1; k > 0; k--)
            {
                if (arr[k] < arr[k - 1])
                {
                    (arr[k], arr[k - 1]) = (arr[k - 1], arr[k]);
                }
                else
                {
                    break;
                }
            }
        }
    }
}