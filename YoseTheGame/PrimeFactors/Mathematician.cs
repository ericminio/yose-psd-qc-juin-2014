using System.Collections.Generic;

namespace YoseTheGame.PrimeFactors
{
    public class Mathematician : Genius
    {
        public List<int> Decompose(int number)
        {
            var factors = new List<int>();

            var prime = 2;
            while (number%prime == 0)
            {
                factors.Add(prime);
                number /= prime;
            }

            return factors;
        }
    }
}