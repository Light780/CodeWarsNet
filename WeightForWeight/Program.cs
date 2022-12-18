using System;
using System.Linq;

namespace WeightForWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(orderWeight("103 123 4444 99 2000"));
        }
        public static string orderWeight(string strng)
        {
            return string.Join(" ", strng.Split(' ').OrderBy(item => item.Sum(ch => ch - '0')).ThenBy(str => str));
        }
        
    }
}
