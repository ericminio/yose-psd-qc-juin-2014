namespace YoseTheGame.Controllers
{
    public class StringGuard
    {
        public NotANumberError Response(string input)
        {
            return new NotANumberError
            {
                number = input,
                error = "not a number"
            };
        }
    }
}