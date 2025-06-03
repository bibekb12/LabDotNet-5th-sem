using System;

namespace LabDotNet
{
    public class Question6
    {
        public void GreaterNumbers()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"{a} is greater than {b}");
            else if (b > a)
                Console.WriteLine($"{b} is greater than {a}");
            else
                Console.WriteLine("Both numbers are equal");

        }
    }
}
