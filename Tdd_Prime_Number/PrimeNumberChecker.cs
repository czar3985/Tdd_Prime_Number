namespace Tdd_Prime_Number
{
    public class PrimeNumberChecker
    {
        public bool IsPrime(int number)
        {
            // Prime Number: a number that is divisible only by itself and 1.
            for (var divisor = 2; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
