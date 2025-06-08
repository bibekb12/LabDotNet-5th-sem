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
            var q6 = new Question6();
            var q7 = new Question7();
            var q8 = new Question8();
            var q9 = new Question9();
            var q10 = new Question10();
            var q11 = new Question11();
            var q12 = new Question12();


            //calling each one
            q1.OddEvenFnction();
            q2.SumArray();
            q3.MaxMinDifference();
            q4.ReplaceNegative();
            q5.ReverseArray();
            q6.GreaterNumbers();
            q7.GreaterThanFifty();
            q8.Factorial();
            q9.Pointer();
            q10.FizzBuzz();
            q11.DuplicateArray();
            q12.PrimeNumber();

        }
    }
}