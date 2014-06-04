using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    class HappyPathTest
    {
        private HappyPath happyPath;

        [SetUp]
        public void ThisRoute()
        {
            happyPath = new HappyPath();
        }

        [Test]
        public void MatchesIntegers()
        {
            Assert.That(happyPath.Matches("18"));
        }

        [Test]
        public void DoesNotMatchStrings()
        {
            Assert.False(happyPath.Matches("batman"));
        }

        [Test]
        public void TheResponseContainsTheReceivedNumber()
        {
            var response = (DecompositionResponse) happyPath.Response("16");

            Assert.That(response.number, Is.EqualTo(16));
        }

        [Test]
        public void AsksForHelpToAGenius()
        {
            var genius = Substitute.For<Genius>();
            happyPath.Genius = genius;
            happyPath.Response("16");

            genius.Received().Decompose(16);
        }

        [Test]
        public void TheResponseContainsTheDecompositionGivenByTheGenius()
        {
            var genius = Substitute.For<Genius>();
            happyPath.Genius = genius;
            var decompositionGivenByGenius = new List<int> { 78, 2, 300 };
            genius.Decompose(4).Returns(decompositionGivenByGenius);
            var response = (DecompositionResponse) happyPath.Response("4");

            Assert.That(response.decomposition, Is.EqualTo(decompositionGivenByGenius));
        }
    }
}
