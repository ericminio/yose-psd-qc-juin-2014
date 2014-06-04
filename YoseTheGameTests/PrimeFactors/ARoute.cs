using NSubstitute;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    public class ARoute
    {
        public static IAmARoute MatchingAnyInputAndResponding(string answer)
        {
            var stub = Substitute.For<IAmARoute>();
            stub.Matching(Arg.Any<string>()).Returns(true);
            stub.RespondTo(Arg.Any<string>()).Returns(answer);

            return stub;
        }

        public static IAmARoute NotMatchingAnyInput()
        {
            var stub = Substitute.For<IAmARoute>();
            stub.Matching(Arg.Any<string>()).Returns(false);

            return stub;
        }
    }
}
