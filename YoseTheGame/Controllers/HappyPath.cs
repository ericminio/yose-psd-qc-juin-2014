using System;
using System.Collections.Generic;

namespace YoseTheGame.Controllers
{
    public class HappyPath
    {
        public Genius Genius = new Mathematician();

        public DecompositionResponse Response(string input)
        {
            int number = Convert.ToInt32(input);
            var decomposition = Genius.Decompose(number);
            
            return new DecompositionResponse
            {
                number = number, 
                decomposition = decomposition
            };
        }
    }
}