namespace YoseTheGame.PrimeFactors
{
    public interface IAmARoute
    {
        object RespondTo(string input);
        bool Matching(string input);
    }
}