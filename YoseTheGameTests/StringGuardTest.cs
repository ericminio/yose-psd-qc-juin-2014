using NUnit.Framework;
using YoseTheGame.Controllers;

namespace YoseTheGameTests
{
    [TestFixture]
    class StringGuardTest
    {
        private StringGuard stringGuard;

        [SetUp]
        public void ThisPath()
        {
            stringGuard = new StringGuard();
        }

        [Test]
        public void TheResponseContainsTheReceivedInput()
        {
            var response = stringGuard.Response("ironman");

            Assert.That(response.number, Is.EqualTo("ironman"));
        }

        [Test]
        public void TheResponseContainsTheSpecificError()
        {
            var response = stringGuard.Response("ironman");

            Assert.That(response.error, Is.EqualTo("not a number"));
        }
    }
}