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
            */
            FlipCoin.FlipCoinMethod();
        }
    }
}