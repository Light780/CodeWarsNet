using System;
using System.Linq;

namespace TakeATenMinutesWalk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length == 1 || walk.Length!=10) return false;
            int x = 0, y = 0;
            for (int i = 0; i < walk.Length; i++)
            {
                string dir = walk[i];
                if (dir == "n") y++;
                else if (dir == "s") y--;
                else if (dir == "e") x++;
                else if (dir == "w") x--;
            }
            return x == 0 && y == 0;
        }
    }
}
