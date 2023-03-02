namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programming");
            /*
            UC-01-FlipCoin
                Flip Coin and print percentage of Heads and Tails
                a.I / P->The number of times to Flip Coin. Ensure it is a positive integer.
                b.Logic->Use Random Function to get value between 0 and 1.If < 0.5 then tails or heads
                c.O / P->Percentage of Head vs Tails

                 FlipCoin.FlipCoinMethod();
            */

            /*
           UC-02-Leap Year
                a.I / P->Year, ensure it is a 4 digit number.
                b.Logic->Determine if it is a Leap Year.
                c.O / P->Print the year is a Leap Year or not.

                 LeapYear.FindLeapYear();
            */

            /*
             * * Power of 2
                a. Desc -> This program takes a command-line argument N and prints a table of the
                    powers of 2 that are less than or equal to 2^N.
                b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
                c. Logic -> repeat until i equals N.
                d. O/P -> Print the year is a Leap Year or not.
             */

            PowerOf2.findPowerOfTwo();


        }
    }
}