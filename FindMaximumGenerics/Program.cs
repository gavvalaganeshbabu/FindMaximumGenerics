using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO TestMaximum Application By Using Generics :");
            Console.WriteLine("Enter the Values What you want to check :");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float output = FindMaximum.FindMaximumValue(a, b, c);
            Console.WriteLine("Maximum Value = " + output);
        }
    }
}
