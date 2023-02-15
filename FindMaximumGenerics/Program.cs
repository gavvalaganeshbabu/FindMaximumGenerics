using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = FindMaximum.GetMaximum<int>(456, 254, 385);
            Console.WriteLine($"Maximum= {output}");
            float output1 = FindMaximum.GetMaximum<float>(135.5f, 335.5f, 275.5f);
            Console.WriteLine($"Maximum= {output1}");
            string output2 = FindMaximum.GetMaximum<string>("Ganesh", "Gavvala", "The");
            Console.WriteLine($"Maximum= {output2}");
        }
    }
}
