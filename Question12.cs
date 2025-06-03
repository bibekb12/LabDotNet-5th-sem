namespace LabDotNet
{
    public class Question12
    {
        public void PrimeNumber()
        {
            bool IsPrime(int number)
            {
                if (number < 2) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            int[] numbers = { 3, 4, 7, 10, 13, 17, 20, 23, 29, 30 };

            foreach (int num in numbers)
            {
                if (IsPrime(num))
                    Console.WriteLine($"{num} is a prime number");
                else
                    Console.WriteLine($"{num} is not a prime number");
            }
            Console.ReadLine();

        }
    }
}