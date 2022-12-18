using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Your_order_please
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Order("4of Fo1r pe6ople g3ood th5e the2"));
        }
        public static string Order(string words)
        {
            if (words == "") return "";
            string[] arr = words.Split(' ');
            string[] newArr = new string[arr.Length];
            foreach (var str in arr)
            {
                string number = new string(str.Where(char.IsDigit).ToArray());
                newArr[int.Parse(number)-1] = str;                
            }            
            return string.Join(" ", newArr);
        }
    }
}
