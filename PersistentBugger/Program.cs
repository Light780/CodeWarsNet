using System;
using System.Linq;

namespace PersistentBugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(39));
        }
        public static int Persistence(long n)
        {
            string[] array = n.ToString().Select(x => new string(x, 1)).ToArray();
            if (array.Length == 1) return 0;
            int count = 0;
            while(array.Length != 1)
            {
                n = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    n *= Convert.ToInt32(array[i]);
                }                
                array = n.ToString().Select(x => new string(x, 1)).ToArray();
                count++;
            }
            return count;
        }
    }
}
