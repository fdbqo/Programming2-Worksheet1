/*
 * Name : Finn De Bie
 * Date : 1 - 2 - 23
 * Desc : 
 */

/*
 * An internet cafe charges a €2.00 minimum fee to use the internet for up to three hours.
 * The cafe charges an additional €0.50 per hour for each additional hour or part thereof. 
 * The maximum charge for any given session is €10.00.  . 
Write a program that calculates and displays the charges for each customer who uses the cafe.
Your program will accept the hours used by each customer. 
The program will display the charge for each customer and a running total for all usage. 
The program will keep prompting for user input until the user enters -999.
*/

namespace Part_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter number of hours (-999 to quit) : ");
            int hours = int.Parse(Console.ReadLine());

            double totalReceipt = 0.00;

            while (hours != -999)
            {
                double result = CalculateCharge(hours);
                totalReceipt += result;
                Console.WriteLine($"\nCustomer charge {result:c}     Total Receipt {totalReceipt:c}");

                Console.Write("\nEnter number of hours (-999 to quit) : ");
                hours = int.Parse(Console.ReadLine());
                // user input for loop and result
            }
            

           
        }

        static double CalculateCharge(int hours)
        {
            const double MAX_COST = 10.00;
            const double HOURLY_COST = 0.50;
            double customerCharge = 0;
            
            if (hours == -999)
            {
                Console.WriteLine("\n-999 entered, exiting");
                System.Environment.Exit(0);
            }

            if (hours <= 3)
            {
                customerCharge = 2.00;
            }

            if (hours >= 3)
            {
                customerCharge = 2.00;
                customerCharge = customerCharge + ((hours-3) * HOURLY_COST);
                if (customerCharge > MAX_COST)
                {
                    customerCharge = MAX_COST;
                }
            }
            // calculates and returns customer charge based on input
            return customerCharge;

        }

    }
}