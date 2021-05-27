using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Recurssion
    {
        public void Run()
        {
            var tens = Tens(new List<int>());

            foreach (var t in tens)
                System.Console.WriteLine(t);
        }

        private List<int> Tens(List<int> tens)
        {
            if (tens.Count == 10)
                return tens;

            tens.Add((tens.Count + 1) * 10);

            return Tens(tens);
        }
    }
}