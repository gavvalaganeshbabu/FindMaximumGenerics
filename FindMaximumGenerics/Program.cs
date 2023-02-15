using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO TestMaximum Application By Using Generics :");
            Console.WriteLine("Enter the Values What you want to check :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int output = FindMaximum.FindMaximumValue(a, b, c);
            Console.WriteLine("Maximum Value = " + output);
        }
    }
}
