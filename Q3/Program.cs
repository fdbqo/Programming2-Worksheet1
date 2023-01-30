namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            PrintTriangle();

            Console.WriteLine();

            PrintTriangleUpsideDown();

            Console.WriteLine();

            Console.Write("Enter number of rows : ");
            int rows = int.Parse(Console.ReadLine());

            PrintTriangleGeneral(rows);

            Console.WriteLine();

            Console.Write("Enter number of rows : ");
            int rows2 = int.Parse(Console.ReadLine());

            Console.Write("Enter character : ");
            string character = Console.ReadLine();  

            PrintTriangleGeneralCharacter(rows2, character);

        }

        static void PrintTriangle()
        {
            string hash = "#";
            
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{hash}");
                    
                }
                Console.WriteLine();
            }

        }
        // prints triangle

        static void PrintTriangleUpsideDown()
        {
            string hash = "#";

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{hash}");

                }
                Console.WriteLine();
            }
        }
        // prints upside down

        static void PrintTriangleGeneral(int rows)
        {
            string hash = "#";

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{hash}");

                }
                Console.WriteLine();
            }

        }
        // prints triangle based on user input

        static void PrintTriangleGeneralCharacter(int rows2, string character)
        {
            
            for (int i = 0; i <= rows2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{character}");

                }
                Console.WriteLine();
            }

        }
        // prints rows and character based on user input

    }
}