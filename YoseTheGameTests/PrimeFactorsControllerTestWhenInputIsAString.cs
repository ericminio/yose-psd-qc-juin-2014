using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    class PrimeFactorsControllerTestWhenInputIsAString
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
            Assert.That(controller.Index("batman"), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void ReturnsANotANumberError()
        {
            Assert.That(((JsonResult)controller.Index("ironman")).Data, Is.InstanceOf<NotANumberError>());
        }
    }
}
