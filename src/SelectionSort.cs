using System;
using System.Linq;

namespace Algorithms
{
    public class SelectionSort
    {
        public void Run()
        {
            var vals = "42809587245624529085290348320985495234113312345714897587191841573751357183571";

            var arr = vals.Select(x => Convert.ToInt32(x.ToString()))
                .ToArray();

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
}