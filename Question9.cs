namespace LabDotNet
{
    public class Question9
    {
        public void Pointer(ref int x, ref int y)
        {
            
                x = 10;
                y = 20;

            int a = 0, b = 0;
            Pointer(ref a, ref b);
            Console.WriteLine($"Values set inside function: a = {a}, b = {b}");

        }
    }
}