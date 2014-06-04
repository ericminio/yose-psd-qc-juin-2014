using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.Controllers
{
    [TestFixture]
    public class PrimeFactorsControllerTest
    {
        private PrimeFactorsController controller;

        [SetUp]
        public void TheReturnedResponse()
        {
            controller = new PrimeFactorsController();
        }

        [Test]
        public void ReturnsJson()
        {
            Assert.That(controller.Index("8"), Is.InstanceOf<JsonResult>());
        }
    }
}
