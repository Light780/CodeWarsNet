using System;

namespace LonelyFrogIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JumpTo(9,92));
        }
        public static int JumpTo(int x, int y)
        {
            var steps = 0;
            while (y > x)
            {
                if (y % 2 != 0 || y / 2 < x)
                {
                    y--;
                }
                else
                {
                    y = y / 2;
                }

                steps++;
            }
            return steps;
        }
        
    }
}
