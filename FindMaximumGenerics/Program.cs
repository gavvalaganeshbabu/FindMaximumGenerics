using System;

namespace FindMaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO TestMaximum Application By Using Generics :");
<<<<<<< HEAD
            Console.WriteLine("Enter the String values What you want to check :");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string output = FindMaximum.MaxString(a, b, c);
            Console.WriteLine("Maximum Value = " + output);
=======
            int output = FindMaximum<int>.GetMaximum(29, 256, 598);
            Console.WriteLine($"Maximum= {output}");
            float output1 = FindMaximum<float>.GetMaximum(153.5f, 233.5f, 455.5f);
            Console.WriteLine($"Maximum= {output1}");
            string output2 = FindMaximum<string>.GetMaximum("Ganesh", "Gavvala", "The Great");
            Console.WriteLine($"Maximum= {output2}");
>>>>>>> UC4
        }
    }
}
