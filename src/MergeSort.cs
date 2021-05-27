using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class MergeSort
    {
        public void Run()
        {
            var vals = "4280959803475496512894193417346891273416348012641375287436716" +
            "791193841360164317046565267519344361064517654916394716397651387647183467" +
            "647861879174027153871751707147345734156341693418973461329461287439381387" + 
            "428095980347549651289419341734689127341634801264137528743678846653222416" +
            "791193841360164317046565267519344361064517654916394716397651387647183467" +
            "647861879174027153871751707147345734156341693418973461329461287439381387";

            var unsorted = vals.Select(x => Convert.ToInt32(x.ToString())).ToList();

            var sorted = Sort(unsorted);

            PrintList(sorted);
        }

        public List<int> Sort(List<int> unsorted)
        {
            if (unsorted.Count == 1) 
                return unsorted;

            var median = unsorted.Count / 2;
            var left = unsorted.Take(median).ToList();
            var right = unsorted.Skip(median).ToList();

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while(left.Any() && right.Any())
            {
                if (left.First() <= right.First())
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            result.AddRange(left);
            result.AddRange(right);

            return result;
        }

        private void PrintList(List<int> list)
        {
            System.Console.WriteLine(list.Aggregate("", (m, n) => m+= $"{n} "));
        }
    }
}