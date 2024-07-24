using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Building_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* print this patten using user input....
             * 1
             * 12
             * 123
             * 1234
             * 12345
             */

            Console.WriteLine("Enter range: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            /*print this patten using user input....
              
              1
              2 2
              3 3 3
              4 4 4 4
              5 5 5 5 5
             */


            Console.WriteLine("Enter the number of Rows: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            /* print this patten using user input....
             
               54321
               5432
               543
               54
               5
              */

            Console.WriteLine("Enter a row:");
            int rows2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = rows1; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            /* print this patten using user input....
               1
               1 0
               1 0 1
               1 0 1 0
               1 0 1 0 1
             */

            Console.WriteLine("Enter a rows");
            int rows3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows2; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write(0 + " ");
                    }
                    else
                    {
                        Console.Write(1 + " ");
                    }
                }
                Console.WriteLine();
            }


            /* print this patten using user input....
                   *
                  ***
                 *****
                *******
               *********
                *******
                 *****
                  ***
                   *

             */


            Console.Write("Enter the number of rows for the diamond: ");
            int rows4 = int.Parse(Console.ReadLine());

            // Print the top half of the pattern
            for (int i = 1; i <= rows4; i++)
            {
                // Print leading spaces
                for (int j = 1; j <= rows4 - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                // Move to the next line
                Console.WriteLine();
            }

            // Print the bottom half of the pattern
            for (int i = rows4 - 1; i >= 1; i--)
            {
                // Print leading spaces
                for (int j = 1; j <= rows4 - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                // Move to the next line
                Console.WriteLine();
                
            }


        }
}
