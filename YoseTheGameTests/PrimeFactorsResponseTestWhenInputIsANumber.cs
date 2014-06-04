using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    public class PrimeFactorsResponseTestWhenInputIsANumber
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
        
    }
}
