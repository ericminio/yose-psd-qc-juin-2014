using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    class PrimeFactorsResponseTestWhenInputIsAString
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
            Assert.That(router.Response("batman"), Is.InstanceOf<NotANumberError>());
        }
    }
}
