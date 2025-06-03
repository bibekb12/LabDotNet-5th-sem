using System;

namespace LabDotNet
{
    public class Question4
    {
        public void ReplaceNegative()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Feed 10 integers (with negative value): ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Element {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < 0)
                    numbers[i] = 0;
            }
            Console.WriteLine("Updated negative array with zero '0':");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
