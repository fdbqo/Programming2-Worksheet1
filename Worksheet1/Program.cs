/*
 
 * Name : Finn De Bie
 * Date : 25 - 1 - 23
 * Desc : Revision

 */

using System;

namespace Worksheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop -----");
            PrintIntegersFor();
            
            Console.WriteLine("\n");

            Console.WriteLine("While Loop -----");
            PrintIntegersWhile();

            Console.WriteLine("\n");

            Console.WriteLine("Do While Loop -----");
            PrintIntegersDo();

            Console.WriteLine("\n");

            Console.WriteLine("Excluding 46 & 48 -----");
            PrintExcludingFor();
            // main method 
        }

        static void PrintIntegersFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.Write($"{i}, ");
            }

            // method for printing 40 => 60 , for
        }

        static void PrintIntegersWhile()
        {
            int i = 40;

            while (i >= 40 && i <= 60)
            {
                Console.Write($"{i}, ");
                i++;
            }

            // method for printing 40 => 60 ,  while
        }

        static void PrintIntegersDo()
        {
            int i = 40;

            do
            {
                Console.Write($"{i}, ");
                i++;

            } while (i <= 60);

            // method for printing 40 => 60 , do while
        }

        static void PrintExcludingFor()
        {
            int excluded1 = 46;
            int excluded2 = 48;

            for (int i = 40; i <= 60; i++)
            {
                if (i == excluded1)
                {
                    i++;
                }
                if (i == excluded2)
                {
                    i++;
                }
                Console.Write($"{i}, ");

            }

            // method for printing nums excluding specifics 
        }

    }
}