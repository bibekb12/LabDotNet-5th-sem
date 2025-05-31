using System;

public class Question3
{
    public void MaxMinDifference()
    {
        int[] numbers = { 5, 10, 3, 8, 15, 1, 9, 6, 20, 7 };

        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }
        Console.WriteLine($"Maximum number is : {max}");
        Console.WriteLine($"Minimun number is : {min}");
        Console.WriteLine($"Difference: {max - min}");
        Console.ReadLine();
    }
}
