using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                double parsedNum = double.Parse(num); //парсваме стринга в число
                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
           
            }
            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, counts[num]);
            }
        }
    }
}
