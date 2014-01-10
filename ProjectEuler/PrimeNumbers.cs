using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class PrimeNumbers
    {
        public static List<int> GetPrimes(int upToNumber)
        {
            var primeNumbers = new List<int>();

            for (int i = 2; i <= upToNumber; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var isPrime = true;
            var max = (int)Math.Sqrt(number);
            for (int i = 2; i <= max; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
