using System.Collections.Generic;
using System.Web.Mvc;
using NSubstitute;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsControllerTest
    {
        private PrimeFactorsController controller;

        [SetUp]
        public void ThisController()
        {
            controller = new PrimeFactorsController();
        }

        [Test]
        public void ReturnsJson()
        {
            Assert.That(controller.Index("8"), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void ReturnsADecompositionResponse()
        {
            Assert.That(((JsonResult)controller.Index("8")).Data, Is.InstanceOf<DecompositionResponse>());
        }

        [Test]
        public void TheResponseContainsTheReceivedNumber()
        {
            var response = (DecompositionResponse)((JsonResult)controller.Index("8")).Data;

            Assert.That(response.number, Is.EqualTo(8));
        }

        [Test]
        public void AsksForHelpToAGenius()
        {
            var genius = Substitute.For<Genius>();
            controller.Genius = genius;
            controller.Index("16");

            genius.Received().Decompose(16);
        }

        [Test]
        public void TheResponseContainsTheDecompositionGivenByTheGenius()
        {
            var genius = Substitute.For<Genius>();
            controller.Genius = genius;
            var decompositionGivenByGenius = new List<int> { 78, 2, 300 };
            genius.Decompose(4).Returns(decompositionGivenByGenius);
            var response = (DecompositionResponse)((JsonResult)controller.Index("4")).Data;

            Assert.That(response.decomposition, Is.EqualTo(decompositionGivenByGenius));
        }
    }
}
