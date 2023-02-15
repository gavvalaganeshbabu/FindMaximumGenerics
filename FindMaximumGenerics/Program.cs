using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = FindMaximum<int>.GetMaximum(215, 7825, 2725);
            Console.WriteLine($"max={output}");
            float output1 = FindMaximum<float>.GetMaximum(34.5f, 253.5f, 334.5f);
            Console.WriteLine($"max={output1}");
            string output2 = FindMaximum<string>.GetMaximum("Ganesh", "Gavvala", "The");
            Console.WriteLine($"max={output2}");

        }
    }
}
