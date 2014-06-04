using System;

namespace YoseTheGame.PrimeFactors
{
    public class HappyPath : IAmARoute
    {
        public Genius Genius = new Mathematician();

        public object Response(string input)
        {
            int number = Convert.ToInt32(input);
            var decomposition = Genius.Decompose(number);
            
            return new DecompositionResponse
            {
                number = number, 
                decomposition = decomposition
            };
        }

        public bool Matches(string input)
        {
            int number;
            return Int32.TryParse(input, out number);
        }
    }
}