using System.Web.Mvc;
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
    }
}
