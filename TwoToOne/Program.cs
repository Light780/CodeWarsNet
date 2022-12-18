using System;
using System.Linq;

namespace TwoToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "xyaabbbccccdefww";
            var b = "xxxxyyyyabklmopq";
            Console.WriteLine(Longest(a, b));
        }
        public static string Longest(string s1, string s2)
        {
            return new string(string.Concat(s1, s2).ToCharArray().Distinct().OrderBy(x => x).ToArray());
        }
    }
}
