namespace YoseTheGame.PrimeFactors
{
    public class PrimeFactorsRouter
    {
        private readonly HappyPath happyPath = new HappyPath();
        private readonly StringGuard stringGuard = new StringGuard();
        
        public object Response(string number)
        {
            int any;
            if (int.TryParse(number, out any))
            {
                return happyPath.Response(number);
            }
            else
            {
                return stringGuard.Response(number);
            }
        }
    }
}