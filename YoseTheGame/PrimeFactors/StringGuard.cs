namespace YoseTheGame.PrimeFactors
{
    public class StringGuard : IAmARoute
    {
        public object Response(string input)
        {
            return new NotANumberError
            {
                number = input,
                error = "not a number"
            };
        }

        public bool Matches(string input)
        {
            return ! new HappyPath().Matches(input);
        }
    }
}