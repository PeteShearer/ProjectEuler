using System;

namespace ProjectEuler
{
    /// <summary>  
    /// The prime factors of 13195 are 5, 7, 13 and 29.  
    ///  What is the largest prime factor of the number 600851475143 ?  
    /// http://projecteuler.net/index.php?section=problems&id=3  
    ///  
    /// The answer is 6857  
    /// I blogged this at http://www.peteonsoftware.com/index.php/2010/10/07/project-euler-problem-three/
    /// </summary>  
    public class ProblemThree
    {
        protected static double number = 600851475143;

        public static double Solve()
        {
            double limit = Math.Floor(Math.Sqrt(number));
            double currentLargestPrime = 0;

            for (double i = 2; i <= limit; i++)
            {
                if (IsPrime(i) && (number % i == 0))
                {
                    currentLargestPrime = i;
                }
            }

            return currentLargestPrime;
        }

        public static bool IsPrime(double n)
        {
            if (n % 2 == 0) return false;

            var upperLimit = Math.Floor(Math.Sqrt(n));

            for (double i = 3; i <= upperLimit; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }  
    }
}
