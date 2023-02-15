using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO TestMaximum Application By Using Generics :");
            Console.WriteLine("Enter the String values What you want to check :");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string output = FindMaximum.MaxString(a, b, c);
            Console.WriteLine("Maximum Value = " + output);
        }
    }
}
