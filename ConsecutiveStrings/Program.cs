using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsec(new String[] { }, 3));
        }
        public static string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k <= 0 || k > strarr.Length) return "";
            strarr = strarr.Distinct().ToArray();
            string[] newArr = new string[strarr.Length];
            for (int i = 0; i < strarr.Length; i++)
            {
                newArr[i] = string.Join("",strarr.Skip(i).Take(k));
            }            
            return  k != 1 
                ? newArr.Where(x => !x.Equals(newArr[newArr.Length - 1])).OrderByDescending(x => x.Length).First()
                : newArr.OrderByDescending(x => x.Length).First();
        }
    }
}
