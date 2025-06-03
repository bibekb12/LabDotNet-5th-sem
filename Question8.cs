using System;

namespace LabDotNet
{
    public class Question8
    {
        public void Factorial()
        {
            int Factorial(int n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            Console.WriteLine("5! = " + Factorial(5));

        }
    }
}
