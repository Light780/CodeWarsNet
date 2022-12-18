using System;
using System.Linq;

namespace ExesAndOhs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO("xxxm"));
        }
        public static bool XO(string input)
        {
            var xs = input.ToLower().ToCharArray().AsEnumerable().Where(x => x.Equals('x')).Count();
            var os = input.ToLower().ToCharArray().AsEnumerable().Where(x => x.Equals('o')).Count();
            return xs == os;
        }
    }
}
