using System;

namespace LabDotNet
{
    public class Question1
    {
        public void OddEvenFnction()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} is {(num % 2 == 0 ? "Even" : "odd")}");

            }
            Console.ReadLine();
        }
    }
}