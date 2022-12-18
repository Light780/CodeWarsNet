using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DetectPangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog."));
        }
        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(x => char.IsLetter(x)).GroupBy(x => x).Count() == 26;
        }
    }
}
