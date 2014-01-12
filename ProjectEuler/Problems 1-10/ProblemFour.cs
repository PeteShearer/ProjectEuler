using System;

namespace ProjectEuler
{
    /// <summary>  
    /// A palindromic number reads the same both ways. The largest  
    /// palindrome made from the product of two 2-digit numbers is   
    ///  9009 = 91 Ã— 99.  
    /// Find the largest palindrome made from the product of two 3-digit numbers.  
    ///  http://projecteuler.net/index.php?section=problems&id=43  
    ///  
    /// The answer is 906609  
    /// Originally blogged at http://www.peteonsoftware.com/index.php/2010/10/08/project-euler-problem-4/
    /// </summary>  
    public class ProblemFour
    {
        public static string Solve()
        {
            var max = 0;
            var theI = 0;
            var theK = 0;

            for (var i = 100; i <= 999; i++)
            {
                for (var k = 100; k <= 999; k++)
                {
                    var product = i * k;
                    if (IsPalindrome(product) && product > max)
                    {
                        theI = i;
                        theK = k;
                        max = product;
                    }
                }
            }

            return string.Format("Using {0} and {1}, the max palindrome is {2}", theI, theK, max);
        }

        public static bool IsPalindrome(int number)
        {
            var forward = number.ToString();
            var reverse = forward.ToCharArray();
            Array.Reverse(reverse);

            return forward == new string(reverse);
        }  
    }
}
