/*
 * Power of 2
    a. Desc -> This program takes a command-line argument N and prints a table of the
        powers of 2 that are less than or equal to 2^N.
    b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
    c. Logic -> repeat until i equals N.
    d. O/P -> Print the year is a Leap Year or not.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOf2
    {
        public static void findPowerOfTwo()
        {
            int e;
            int result;

            for (int i = 0; i < 10; i++)
            {
                result = 1;
                e = i;

                while (e > 0)
                {
                    result *= 2;
                    e--;
                }

                Console.WriteLine("2 to the " + i + " power is " + result);
            }
        }
    }
}
