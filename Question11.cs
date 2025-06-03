namespace LabDotNet
{
    public class Question11
    {
        public void DuplicateArray()
        {
            int[] arr = { 2, 5, 7, 2, 8, 9, 5, 3, 1, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate found: {arr[i]}");
                        Console.ReadLine();
                        break;
                    }
                }
            }

        }
    }
}