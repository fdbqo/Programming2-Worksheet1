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
            PrintIntegersFor();

            Console.WriteLine();

            PrintIntegersWhile();



        }

        static void PrintIntegersFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.Write($"{i}, ");
            }

        }

        static void PrintIntegersWhile()
        {
            int i = 40;

            while (i >= 40 && i <= 60)
            {
                Console.Write($"{i}, ");
                i++;
            }
        }
    }
}