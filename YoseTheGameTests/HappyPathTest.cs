using System.Collections.Generic;
using System.Web.Mvc;
using NSubstitute;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    class HappyPathTest
    {
        HappyPath happyPath;

        [SetUp]
        public void ThisPath()
        {
            happyPath = new HappyPath();
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
            var response = happyPath.Response("4");

            Assert.That(response.decomposition, Is.EqualTo(decompositionGivenByGenius));
        }
    }
}
