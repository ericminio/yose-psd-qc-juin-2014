using System.Web.Mvc;
using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests.Controllers
{
    [TestFixture]
    public class PingControllerTest
    {
        private ActionResult _result;

        [SetUp]
        public void ThisController()
        {
            var controller = new PingController();
            _result = controller.Index();
        }

        [Test]
        public void ReturnsJson()
        {            
            Assert.That(_result, Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void ReturnsTheExpectedJson()
        {
            var json = (JsonResult) _result;

            Assert.That(json.Data.ToString(), Is.EqualTo("{ alive = True }"));
        }

    }
}
