using System.Collections.Generic;

namespace YoseTheGame.PrimeFactors
{
    public class DecompositionResponse
    {
        public int number { get; set; }
        public List<int> decomposition { get; set; }
    }
}