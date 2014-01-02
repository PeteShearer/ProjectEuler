using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class ProblemSix
    {
        public static double Solve(int howManyPlaces)
        {
            var sum = SumOfSquares(howManyPlaces);
            var square = SquareOfSums(howManyPlaces);
            return square - sum;
        }

        protected static double SumOfSquares(int howManyNumbers)
        {
            double sum = 0;

            for (var i = 1; i <= howManyNumbers; i++)
            {
                sum += i*i;
            }

            return sum;
        }

        protected static double SquareOfSums(int howManyNumbers)
        {
            double sum = 0;

            for (var i = 1; i <= howManyNumbers; i++)
            {
                sum += i;
            }

            return sum*sum;
        }
    }
}
