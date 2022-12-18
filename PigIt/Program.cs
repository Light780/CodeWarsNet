using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PigIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello World !"));
        }
        public static string PigIt(string str)
        {
            Regex regex = new Regex(@"[a-zA-Z]+");
            return string.Join(" ",str.Split(" ")
                .Select(s => regex.Match(s).Success ? string.Concat(s.Substring(1,s.Length-1),s[0],"ay"): s));
        }
    }
}
