namespace ProjectEuler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
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
