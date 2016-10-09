using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sortedNums= nums.OrderByDescending(x => x);
            var largest3Nums = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ",largest3Nums));

        }
    }
}
