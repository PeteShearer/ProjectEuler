using System.Linq;

namespace ProjectEuler
{
    /// <summary>  
    /// Problem 1  
    /// 05 October 2001  
    /// If we list all the natural numbers below 10   
    /// that are multiples of 3 or 5, we get 3, 5, 6   
    /// and 9. The sum of these multiples is 23.  
    ///    
    /// Find the sum of all the multiples of 3 or 5 below 1000.  
    /// </summary>  
    public class ProblemOne
    {
        public static int Solve()
        {
            int answer = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (IsMultipleOfThreeOrFive(i))
                {
                    answer += i;
                }
            }

            return answer;
        }

        public static bool IsMultipleOfThreeOrFive(int number)
        {
            return (((number % 3) == 0) || ((number % 5) == 0));
        }

        public static int SolveWithLinq()  
        {  
            var problemSet = from i in  
                             Enumerable.Range(1, 999)  
                             where (((i % 3).Equals(0)) || ((i % 5).Equals(0)))  
                             select i;  
  
            return problemSet.Sum();  
        }  
    }
}
