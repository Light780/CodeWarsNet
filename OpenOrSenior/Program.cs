using System;
using System.Collections.Generic;
using System.Linq;
namespace OpenOrSenior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> results = OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });

            foreach(string s in results)
            {
                Console.WriteLine(s);
            }
        }
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> results = new List<string>();
            data.AsEnumerable().ToList().ForEach(x => {
                results.Add(x[0] >= 55 && x[1] > 7 ? "Senior" : "Open");
            });
            return results;
        }
    }
}
