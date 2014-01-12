using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// a2 + b2 = c2
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class ProblemNine
    {
        // Just Brute Forcing This Bad Boy
        public static int Solve()
        {
            int answer = 0;

            for (var a = 1; a < 1000; a++ )
            {
                for (var b = 1; b < 1000; b++)
                {
                    var c = 1000 - a - b;
                    var leftSide = Math.Pow(a, 2) + Math.Pow(b, 2);
                    var rightSide = Math.Pow(c, 2);
                    if (leftSide == rightSide)
                    {
                        Console.WriteLine("The Numbers are {0}, {1}, and {2}", a, b, c);
                        return a * b * c;
                    }
                }
            }

            return answer;
        }
    }
}
