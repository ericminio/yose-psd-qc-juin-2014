namespace YoseTheGame.PrimeFactors
{
    public class StringGuard : IAmARoute
    {
        public object RespondTo(string input)
        {
            return new NotANumberError
            {
                number = input,
                error = "not a number"
            };
        }

        public bool Matching(string input)
        {
            return ! new HappyPath().Matching(input);
        }
    }
}