using System;

namespace GetMiddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("testing"));
        }

        public static string GetMiddle(string s)
        {

            if (s.Length == 1) return s;

            return s.Length % 2 == 0 
                ? s.Substring(s.Length - (s.Length / 2 + 1), 2) 
                : s.Substring(Convert.ToInt32(s.Length - (s.Length / 2 + 1)), 1);
        }
    }
}
