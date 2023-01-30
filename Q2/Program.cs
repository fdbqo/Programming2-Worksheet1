namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();
        }

        static void CountOddNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter integer {i} : ");
                int test = int.Parse(Console.ReadLine());
            }
        }
    }
}