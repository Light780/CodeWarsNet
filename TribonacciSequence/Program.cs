using System;

namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Tribonacci(new double[] { 19,2,2 }, 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] trib = new double[n];
            if (signature.Length != 3 || n <= 0) return trib;
            Array.Copy(signature, trib,signature.Length > n ? n : signature.Length);
            for (int i = signature.Length; i < trib.Length; i++)
            {
                trib[i] = trib[i - 1] + trib[i - 2] + trib[i - 3];
            }
            return trib;
        }
    }
}
