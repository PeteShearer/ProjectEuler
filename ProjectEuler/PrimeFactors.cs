using System.Collections.Generic;

namespace ProjectEuler
{
    public class PrimeFactors
    {
        public static List<int> Of(int number)
        {
            if (number <= 1) return new List<int>();

            var primeFactors = new List<int>();
            var primes = PrimeNumbers.GetPrimes(number);
            var remainder = number;
            while (remainder > 1)
            {
                foreach (var prime in primes)
                {
                    if (remainder % prime == 0)
                    {
                        primeFactors.Add(prime);
                        remainder = remainder / prime;
                    }
                }
            }

            primeFactors.Sort();

            return primeFactors;
        }
    }
}
