using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsControllerTestWhenInputIsANumber
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
            Assert.That(controller.Index("32"), Is.InstanceOf<JsonResult>());
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
        
    }
}
