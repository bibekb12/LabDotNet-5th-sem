namespace LabDotNet
{
    public class Question10
    {
        public void FizzBuzz()
        {
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i + 1;

                if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
                    Console.WriteLine("fizzbuzz");
                else if (arr[i] % 3 == 0)
                    Console.WriteLine("fizz");
                else if (arr[i] % 5 == 0)
                    Console.WriteLine("buzz");
                else
                    Console.WriteLine(arr[i]);
            }

        }
    }
}