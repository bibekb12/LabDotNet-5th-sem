using System;

namespace LabDotNet
{
    public class Question5
    {
        public void ReverseArray()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Array in reverse order: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            COnsole.WriteLine();
            COnsole.ReadLine();

        }
    }
}
