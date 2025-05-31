using System;

namespace LabDotNet
{
    public class Question2
    {
        public void SumArray()
        {
            int[] numbers = { 3, 5, 7, 2, 8, 10, 1, 4, 6, 9 };
            int sum = 0;
            foreach (int num in numbers)
                sum = sum + num;
            Console.WriteLine($"Sum of array = {sum}");
            Console.ReadLine();
        }
    }
}