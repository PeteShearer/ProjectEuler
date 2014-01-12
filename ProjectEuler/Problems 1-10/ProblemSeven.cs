using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10 001st prime number?
    /// </summary>
    public class ProblemSeven
    {
        public static int Solve()
        {
            int number = 1;
            int counter = 0;

            while (true)
            {
                if (PrimeNumbers.IsPrime(number))
                {
                    counter++;
                    if (counter == 10001) break;
                }

                number++;
            }

            return number;
        }
    }
}
