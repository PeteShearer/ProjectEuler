using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// I originally blogged this with a Scheme approach at http://www.peteonsoftware.com/index.php/2011/09/18/project-euler-problem-5-scheme-style/
    /// </summary>
    public class ProblemFive
    {
        // Dictionary is PrimeFactor and Power
        protected static Dictionary<int, int> _lcmPrimeFactorsWithPowers = new Dictionary<int, int>();

        /// <summary>
        /// This method is much more complex to read and write than the brute force, but will work more efficiently the higher it goes
        /// </summary>
        /// <returns></returns>
        public static double Solve(int numbersUpTo)
        {
            for (var i = 1; i <= numbersUpTo; i++)
            {
                var factors = PrimeFactors.Of(i);

                if (!factors.Any()) continue;

                var groupings = from number in factors
                                group number by number
                                into numberGroup
                                select new {Number = numberGroup.Key, Power = numberGroup.Count()};

                foreach (var item in groupings)
                {
                    if (_lcmPrimeFactorsWithPowers.Keys.Contains(item.Number))
                    {
                        var existingPower = _lcmPrimeFactorsWithPowers[item.Number];
                        if (item.Power > existingPower)
                        {
                            _lcmPrimeFactorsWithPowers[item.Number] = item.Power;
                        }
                    }
                    else
                    {
                        _lcmPrimeFactorsWithPowers[item.Number] = item.Power;
                    }
                }
            }

            // get all of the powers into a list
            var listOfFactorsSimplified = new List<double>();

            foreach (var primeFactorsWithPower in _lcmPrimeFactorsWithPowers)
            {
                listOfFactorsSimplified.Add(Math.Pow(primeFactorsWithPower.Key, primeFactorsWithPower.Value));
            }

            // Multiply them all out
            double answer = 1;

            foreach (var simplifiedFactor in listOfFactorsSimplified)
            {
                answer *= simplifiedFactor;
            }

            return answer;
        }

        public static double SolveBruteForce()
        {
            // Had standard looping check, but changed when I found this:
            // Nice brute force optimization I found from http://www.mathblog.dk/project-euler-problem-5/
            double number = 20; // it has to be divisible by 20, so everything under is useless and we can step by 20 for the same reason
            while (number % 2 != 0 || number % 3 != 0 || number % 4 != 0 || number % 5 != 0 ||
             number % 6 != 0 || number % 7 != 0 || number % 8 != 0 || number % 9 != 0 ||
             number % 10 != 0 || number % 11 != 0 || number % 12 != 0 || number % 13 != 0 ||
             number % 14 != 0 || number % 15 != 0 || number % 16 != 0 || number % 17 != 0 ||
             number % 18 != 0 || number % 19 != 0 || number % 20 != 0)
                {
                    number += 20;
                }
            return number;
        }
    }
}
