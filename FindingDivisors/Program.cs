using System;
using System.Collections.Generic;
using System.Linq;

namespace FindingDivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Divisors(25))
            {
                Console.WriteLine(item);
            }
        }
        public static int[] Divisors(int n)
        {
            List<int> result = new List<int>();
            if (n == 0) return null;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if(n % i == 0)
                    {
                        result.Add(i);
                    }
                }
                
            }
            if (result.Count == 2) return null;
            else return result.Where(x => x != 1 && x!= n).ToArray();            
        }
    }
}
