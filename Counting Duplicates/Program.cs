using System;
using System.Linq;

namespace Counting_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("abcdee"));
        }
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            var result = chars.GroupBy(c => c).Where(c => c.Count() > 1);
            return result.Count();
        }
    }
}
