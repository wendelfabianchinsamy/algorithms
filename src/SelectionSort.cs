public class SelectionSort
{
    public void Run()
    {
        var arr = new int[] { 2, 4, 1, 5, 15, 6, 72, 564, 2, 16, 7, 4, 53, 1 };
        var lowIndex = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            lowIndex = i;

            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[lowIndex])
                {
                    lowIndex = j;
                }
            }

            var temp = arr[i];
            arr[i] = arr[lowIndex];
            arr[lowIndex] = temp;
        }

        foreach (var i in arr)
        {
            System.Console.WriteLine(i);
        }
    }
}