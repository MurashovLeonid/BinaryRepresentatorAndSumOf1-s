using System;
using System.Linq;

namespace ConsoleGeneralTrain
{
    class ArrayAnalyser
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).ToCharArray().Select(i => i - '0').ToArray().Where(i => i == 1).Select(i => i)
                .Sum();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            Console.WriteLine(ArrayAnalyser.CountBits(a));
        }
    }
}
