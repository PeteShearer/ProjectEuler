using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class ProblemTen
    {
        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. Find the sum of all the primes below two million.
        /// </summary>
        /// <returns></returns>
        public static long Solve()
        {
            var primes = PrimeNumbers.GetPrimes(2000000);

            return primes.ConvertAll(p => Convert.ToInt64(p)).Sum();
        }
    }
}
