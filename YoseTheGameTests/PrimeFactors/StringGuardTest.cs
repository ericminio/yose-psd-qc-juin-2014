﻿using NUnit.Framework;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    class StringGuardTest
    {
        private StringGuard stringGuard;

        [SetUp]
        public void ThisRoute()
        {
            stringGuard = new StringGuard();
        }

        [Test]
        public void MatchesStrings()
        {
            Assert.That(stringGuard.Matching("batman"));
        }

        [Test]
        public void DoesNotMatchIntegers()
        {
            Assert.False(stringGuard.Matching("23"));
        }

        [Test]
        public void TheResponseContainsTheReceivedInput()
        {
            var response = (NotANumberError) stringGuard.RespondTo("ironman");

            Assert.That(response.number, Is.EqualTo("ironman"));
        }

        [Test]
        public void TheResponseContainsTheSpecificError()
        {
            var response = (NotANumberError) stringGuard.RespondTo("ironman");

            Assert.That(response.error, Is.EqualTo("not a number"));
        }
    }
}