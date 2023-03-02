/*
 * Flip Coin and print percentage of Heads and Tails
    a. I/P -> The number of times to Flip Coin. Ensure it is a positive integer.
    b. Logic -> Use Random Function to get value between 0 and 1. If < 0.5 then tails or heads
    c. O/P -> Percentage of Head vs Tails
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
      public static void FlipCoinMethod()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage = 0;
            double tailpercentage = 0;

            Console.WriteLine("Enter the number of flip");
            int numofflip = Convert.ToInt32(Console.ReadLine());

            if (numofflip > 0)
            {
                for (int i = 0; i < numofflip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                headpercentage = headcount * 100 / numofflip;
                tailpercentage = tailcount * 100 / numofflip;

                Console.WriteLine("headpercentage" + tailpercentage);
                Console.WriteLine("tailpercentage" + headpercentage);


            }
        }
    }
}
