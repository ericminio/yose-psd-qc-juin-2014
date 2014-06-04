using System.Collections.Generic;
using System.Linq;

namespace YoseTheGame.PrimeFactors
{
    public class PrimeFactorsRouter
    {
        public List<IAmARoute> Routes = new List<IAmARoute>
        {
            new StringGuard(),
            new HappyPath(),
        };

        public object Response(string input)
        {
            return Routes.First(route => route.Matching(input)).RespondTo(input);
        }
    }
}


