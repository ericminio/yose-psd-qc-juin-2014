namespace YoseTheGame.PrimeFactors
{
    public interface IAmARoute
    {
        object Response(string input);
        bool Matches(string input);
    }
}