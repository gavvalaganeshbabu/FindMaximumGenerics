using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = FindMaximum<int>.GetMaximum(15, 25, 5);
            Console.WriteLine($"max={output}");
            float output1 = FindMaximum<float>.GetMaximum(15.5f, 253.5f, 3.5f);
            Console.WriteLine($"max={output1}");
            string output2 = FindMaximum<string>.GetMaximum("abc", "pqr", "lmn");
            Console.WriteLine($"max={output2}");

        }
    }
}
