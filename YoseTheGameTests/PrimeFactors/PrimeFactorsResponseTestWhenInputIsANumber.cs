using NUnit.Framework;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    public class PrimeFactorsResponseTestWhenInputIsANumber
    {
        private PrimeFactorsRouter router;

        [SetUp]
        public void TheRouter()
        {
            router = new PrimeFactorsRouter();
        }

        [Test]
        public void ReturnsADecompositionResponse()
        {
            Assert.That(router.Response("8"), Is.InstanceOf<DecompositionResponse>());
        }        
    }
}
