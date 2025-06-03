using System;

namespace LabDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating each classes
            var q1 = new Question1();
            var q2 = new Question2();
            var q3 = new Question3();
            var q4 = new Question4();
            var q5 = new Question5();
            var q11 = new Question11();
            var q12 = new Question12();

            //calling each one
            q1.OddEvenFnction();
            q2.SumArray();
            q3.MaxMinDifference();
            q4.ReplaceNegative();
            q11.DuplicateArray();
            q12.PrimeNumber();
        }
    }
}