using System;

namespace Algorithms
{
    public class FactorialRecursive
    {

        public int Factorial(int number)
        {
            int factorial = 1;
            if (number == 0)
            {
                return factorial;
            }

            if (number > 0)
            {
                factorial = number * Factorial(number - 1);
                return factorial;
            }

            return 0;
        }
    }
}
