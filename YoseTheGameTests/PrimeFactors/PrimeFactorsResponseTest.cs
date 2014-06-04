using System.Collections.Generic;
using NUnit.Framework;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    class PrimeFactorsResponseTest
    {
        private PrimeFactorsRouter router;

        [SetUp]
        public void TheRouter()
        {
            router = new PrimeFactorsRouter();
        }

        [Test]
        public void UsesRoutes()
        {
            Assert.That(router.Routes, Has.Count.GreaterThan(0));
        }

        [Test]
        public void ReturnsFirstMatchingRouteResponse()
        {
            router.Routes = new List<IAmARoute>
            {
                ARoute.NotMatchingAnyInput(), 
                ARoute.MatchingAnyInputAndResponding("matching")
            };

            Assert.That(router.Response("any input"), Is.EqualTo("matching"));
        }

        [Test]
        public void HasTheFollowingOrderedRoutes()
        {
            int index = 0;
            Assert.That(router.Routes[index++], Is.InstanceOf<StringGuard>());
            Assert.That(router.Routes[index], Is.InstanceOf<HappyPath>());
        }

    }
}
