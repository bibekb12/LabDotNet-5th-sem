namespace LabDotNet
{
    public class Question7
    {
        public void GreateThanFifty()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 101);
                Console.WriteLine(arr[i]);
                if (arr[i] > 50) count++;
            }

            Console.WriteLine($"Numbers greater than 50: {count}");

        }
    }
}