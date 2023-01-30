/*
 * Name : Finn De Bie
 * Date : 30 - 1 - 23
 * Desc : Methods 
 * 
 */

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();

            Console.WriteLine("-----------------------------------\n");

            AverageMinMax();
        }

        static void CountOddNumbers()
        {
            Console.Write($"Enter integer 1 : ");
            int intOne = int.Parse(Console.ReadLine());

            Console.Write($"Enter integer 2 : ");
            int intTwo = int.Parse(Console.ReadLine());

            Console.Write($"Enter integer 3 : ");
            int intThree = int.Parse(Console.ReadLine());

            Console.Write($"Enter integer 4 : ");
            int intFour = int.Parse(Console.ReadLine());

            Console.Write($"Enter integer 5 : ");
            int intFive = int.Parse(Console.ReadLine());
            // user input

            int counter = 0;
            // counter used to count num of odd numbers
            Console.WriteLine("\nOdd Numbers : ");
            if (intOne % 2 != 0)
            {
                Console.WriteLine($" - {intOne}");
                counter++;
            }
            if (intTwo % 2 != 0)
            {
                Console.WriteLine($" - {intTwo}");
                counter++;
            }
            if (intThree % 2 != 0)
            {
                Console.WriteLine($" - {intThree}");
                counter++;
            }
            if (intFour % 2 != 0)
            {
                Console.WriteLine($" - {intFour}");
                counter++;
            }
            if (intFive % 2 != 0)
            {
                Console.WriteLine($" - {intFive}");
                counter++;
            }
            // checks for odd numbers using modulus

            Console.WriteLine($"\n- {counter} number(s) are odd\n");
            // displays amount of odd numbers using a counter
        }

        static void AverageMinMax()
        {

            int[] integers = {0, 0, 0, 0, 0};

            for (int i = 0; i <=4 ; i++)
            {
                Console.Write($"Enter integer {i+1} : ");
                integers[i] = int.Parse(Console.ReadLine());
            }

            int min = integers.Min();
            int max = integers.Max();
            var average = integers.Average();

            Console.WriteLine("\n----- Results -----");
            Console.WriteLine($"Average        : {average}");
            Console.WriteLine($"Smallest value : {min}");
            Console.WriteLine($"Largest value  : {max}");



        }
    }
}